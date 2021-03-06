#include <msp430.h>

#include  "../header/api.h"             
#include  "../header/hal.h"             
#include  "../header/bsp.h"
//**********************************************************
//                   Final Project
//==========================================================
//                    Variables
//==========================================================

//==========================================================
//              STATE 1 - manual control
//==========================================================
void stepper_motor_manual_control(void){
    while ((Vx>=radius_min_bruto && Vx<=radius_max_bruto) && (Vy>=radius_min_bruto && Vy<=radius_max_bruto)){
        sampleVxy();
    }
    MoveToJoyStickDiraction();
}
//==========================================================
//              STATE 2 - calibration
//==========================================================
void Joystick_based_PC_painter(void){
//    _BIS_SR(GIE);
//    adc10_config();

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
volatile int opcode;
void script_mode(void){
//            -------- Variables --------
    int script_size_counter;
    int  x_times;//, num_byte;
    unsigned long p, l, r;
    int script_lines_counter;

//             --------  Stage 1 --------
//        Get auxiliary variables to write script


//    __bis_SR_register(LPM0_bits + GIE);
//    s.num_script = receive_int();                               // Get script number


    int cuonter = 0;
    while(cuonter<2){
        __bis_SR_register(LPM0_bits + GIE);
        if(p_rx[index - 1] == '-'){
            cuonter++;
        }
    }

    s.num_script = receive_int();
    index++;

    if(!s.written[s.num_script - 1]){                           // If Script number hasn't written yet in {0,1,2}

        receive_string(&s.size[s.num_script - 1]);              // Get script size
        index++;
        receive_string(&s.lines[s.num_script - 1]);             // Get number of script's lines

//             --------  Stage 2 --------
//               Writing script to flash

        write_to_flash = 1;
        script_size_counter = s.size[s.num_script - 1];         // Script size
        while(script_size_counter--){                           // Until we get all chars in script
            __bis_SR_register(LPM0_bits + GIE);                 // wait for new char in Rx
            write_seg(s.pscript[s.num_script - 1], offset++);   // Write value (char from p_rx[0]) to flash

        }
        s.written[s.num_script - 1] = 1;                        // Mark script already written
        write_to_flash = 0;
        state_flg = 0;
    }

//             --------  Stage 3 --------
//Send Acknowledge after finishing saving the script in memory
        send_ack();
//             --------  Stage 4  ---------
//                   Executing Script

    offset = 0;
    opcode = 0;
    acknowledge = 0;
    script_lines_counter = s.lines[s.num_script - 1];
    while(script_lines_counter > 0){
        // Get Opcode
        opcode = read_mem(2);  // reading Opcode value
//        num_byte = 0;
        switch(opcode){
            case 1:
                x_times = get_x_value();
//                while(read_mem(2) != 0x00) num_byte += 1;   // count the total bytes of information
//                offset -= num_byte * 2;                     // retuen offset to read all
//                x_times = read_mem(num_byte * 2);
                blink_RGB(ScriptModeDelay, x_times);
                break;
            case 2:
                x_times = get_x_value();
//                while(read_mem(2) != 0x00) num_byte += 1;
//                offset -= num_byte * 2;
//                x_times = read_mem(num_byte * 2);
                rlc_leds(ScriptModeDelay, x_times);
                break;
            case 3:
                x_times = get_x_value();
//                while(read_mem(2) != 0x00) num_byte += 1;
//                offset -= num_byte * 2;
//                x_times = read_mem(num_byte * 2);
                rrc_leds(ScriptModeDelay, x_times);
                break;
            case 4:
                ScriptModeDelay = get_x_value();   // update new delay
//                while(read_mem(2) != 0x00) num_byte += 1;
//                offset -= num_byte * 2;
//                ScriptModeDelay = read_mem(num_byte * 2);
                break;
            case 5:
                clear_RGB;
                Leds_CLR;
                break;
            case 6:
                p = read_mem(2);    // get pointed degree
                scan_mode = 1;
                stepper_deg(p);       //
                // Show the degree and distance (dynamically) onto PC screen
                scan_mode = 0;
                break;
            case 7:
                l = read_mem(2);
                r = read_mem(2);
                scan_mode = 1;
                // Show the degree and distance (dynamically) onto PC screen
                stepper_scan(l, r);

                scan_mode = 0;
                break;
            case 8:
                state = 0; // sleep mode
                break;
            default:
                //opcode = 8;
                break;
        }
        if(script_lines_counter)offset+=2;      // If its not the last script line advance the '\n' char in the script
        script_lines_counter--;
    }
    offset = 0;


}




//==========================================================
//              STATE 5- move or stop motor
//==========================================================
void moving_stepper_motor(void){
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
    if (state_stage==stop_motor){ // end of calibration
        state_stage = no_action;
        state = sleep_mode; // sleeping mode

    }
}

























//**********************************************************

//--------------------------------------------------
//volatile int Out_to_RGB = 0x01;
//==========================================================
//                     STATE 1
//==========================================================
//void RGBBlink(int delay){
//
//    clear_RGB();
//    while(state == 1){
//
//        blink_RGB(delay);
//        _BIS_SR(GIE);
//    }
//}
//==========================================================
//                     STATE 2
//==========================================================
void UpCounter(int delay){

    unsigned int SumValTmp;
    char SumValTXT[20] ={'\0'};
    lcd_clear();
    while(state == 2){
        Timer0_A_delay_ms(delay);
        sum_up_value++;

        SumValTmp = (unsigned int) sum_up_value;
        int2str(SumValTXT, SumValTmp);
        lcd_home();
        lcd_puts("c_up: ");
        lcd_puts(SumValTXT);    // print initial label 1 on LCD
        _BIS_SR(GIE);

    }
}
//==========================================================
//                     STATE 3
//==========================================================
void DownCounter(int delay){

    unsigned int SumValTmp;
    char SumValTXT[20] ={'\0'};

    while(state == 3){
        Timer0_A_delay_ms(delay);
        sum_down_value--;

        SumValTmp = (unsigned int) sum_down_value;
        int2str(SumValTXT, sum_down_value);
        lcd_home();
        lcd_puts("c_down: ");
        lcd_puts(SumValTXT);    // print initial label 1 on LCD
        _BIS_SR(GIE);

    }
    }


//==========================================================
//                     STATE 5
//==========================================================
void Potentiometer(void){
    _BIS_SR(GIE);
    adc10_config();
    SC_from_POT();
    int2str(POT,ADC10MEM);   // get pot value from ADC10MEM
    enable_transmition();
}
//==========================================================
//                     STATE 6
//==========================================================
void clear_and_initialize(void){
    sum_up_value = 0;
    sum_down_value = 65535;

    clearing();
    state = 9;
}

//==========================================================
//                     STATE 8
//==========================================================
void Transmit_menu(void){
    enable_transmition();
}

//***********************************************************
//***********************************************************

