#include <msp430.h>

#include  "../header/api.h"             
#include  "../header/hal.h"             
#include  "../header/bsp.h"
//**********************************************************
//                   Final Project
//**********************************************************

//==========================================================
//              STATE 1 - manual control
//==========================================================
void stepper_motor_manual_control(void){
    while ((Vx>=radius_min_bruto && Vx<=radius_max_bruto) && (Vy>=radius_min_bruto && Vy<=radius_max_bruto) && (state==1)){
        sampleVxy();
    }
    MoveToJoyStickDiraction();
}
//==========================================================
//              STATE 2 - joystick painter
//==========================================================
void Joystick_based_PC_painter(void){

    sampleVxy();
}
//==========================================================
//              STATE 3 - calibration
//==========================================================
void stepper_motor_calibration(void){
        SM_Counter = 0;
        moving_stepper_motor();
        Phi_calculation();
}
//==========================================================
//              STATE 4 - Script Mode
//==========================================================
void script_mode(void){
//            -------- Variables --------
    int  x_times;//, num_byte;
    unsigned long p, l, r;
    int script_lines_counter;
    index = 0;
//             --------  Stage 1 --------
//        Get auxiliary variables to write script


    __bis_SR_register(LPM0_bits + GIE);
    s.num_script = receive_int();                               // Get script number



    int cuonter = 0;
    while(cuonter<2){
        __bis_SR_register(LPM0_bits + GIE);
        if(p_rx[index - 1] == '-'){
            cuonter++;
        }
    }
    ScriptNumFlg = 1; // wait for script number in Rx
    index = 0;

    if(!s.written[s.num_script - 1]){                           // If Script number hasn't written yet in {0,1,2}

        receive_string(&s.size[s.num_script - 1]);              // Get script size
        index++;
        receive_string(&s.lines[s.num_script - 1]);             // Get number of script's lines

//             --------  Stage 2 --------
//               Writing script to flash
        script_idx = 0;
        write_to_flash = 1;
        script_size_counter = s.size[s.num_script - 1];         // Script size

        while(script_size_counter-- ){                          // Until we get all chars in script
            __bis_SR_register(LPM0_bits + GIE);                 // wait for new char in Rx
        }

        script_size_counter = s.size[s.num_script - 1];
        write_seg(s.pscript[s.num_script - 1]);   // Write value (char from p_rx[0]) to flash
        s.written[s.num_script - 1] = 1;                        // Mark script already written
        write_to_flash = 0;
        state_flg = 0;

//             --------  Stage 3 --------
//Send Acknowledge after finishing saving the script in memory
                send_ack();
    }


//             --------  Stage 4  ---------
//                   Executing Script
    offset = 0;
    opcode = 0;
    acknowledge = 0;
    if (s.first_written[s.num_script - 1] == 0){
        s.first_written[s.num_script - 1] = 1;
    }else{
        script_lines_counter = s.lines[s.num_script - 1];
            while(script_lines_counter > 0){
                // Get Opcode
                opcode = read_mem(2);  // reading Opcode value
                // execute function
                switch(opcode){
                    case 1:                     // blink RGB leds x times
                        x_times = get_x_value();
                        blink_RGB(ScriptModeDelay, x_times);
                        break;
                    case 2:                     // rotate leds left x times
                        x_times = get_x_value();
                        rlc_leds(ScriptModeDelay, x_times);
                        break;
                    case 3:                     // rotate leds right x times
                        x_times = get_x_value();
                        rrc_leds(ScriptModeDelay, x_times);
                        break;
                    case 4:
                        ScriptModeDelay = get_x_value();   // update new delay
                        break;
                    case 5:                     // clear all leds
                        clear_RGB;
                        Leds_CLR;
                        break;
                    case 6:
                        p = read_mem(2);        // get pointed degree
                        scan_mode = 1;
                        stepper_deg(p);         // Show the degree and distance (dynamically) onto PC screen
                        scan_mode = 0;
                        break;
                    case 7:
                        l = read_mem(2);        // get left degree
                        r = read_mem(2);        // get right degree
                        scan_mode = 1;
                        // Show the degree and distance (dynamically) onto PC screen
                        stepper_scan(l, r);
                        scan_mode = 0;
                        break;
                    case 8:
                        state = sleep_mode;
                        break;
                    default:
                        opcode = 8;
                        break;
                }
                if(script_lines_counter)offset+=2;      // If its not the last script line advance the '\n' char in the script
                script_lines_counter--;
            }
            offset = 0;
    }
    state = sleep_mode;

}


//==========================================================
//              STATE 5- move or stop motor
//==========================================================
void moving_stepper_motor(void){
    _BIS_SR(GIE);
    while (state_stage==start_move_forwards){ // moving forwards until state_stage changes
        _BIS_SR(GIE);
        move_forward();
        step_angle_update();
    }
    while (state_stage==start_move_backwards){ // moving backwards until state_stage changes
        _BIS_SR(GIE);
        move_backward();
        step_angle_update();
    }
    if (state_stage==stop_motor){   // end of calibration
        state_stage = no_action;
        state = sleep_mode;         // sleeping mode

    }
}

