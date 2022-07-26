#include <msp430.h>
///
#include "../header/bsp.h"
#include "../header/hal.h"
#include "../header/api.h"

//  GLOBAL VARIABLES

volatile unsigned int state = sleep_mode;  //Sleeping mode, enable interrupts


void main(void){
	

    InitGPIO();
	InitUART();
	UCA0CTL1 &= ~UCSWRST;                    // Initialize USCI state machine
    IE2 &= ~UCA0TXIE;                        // Disable TX interrupt
    IE2 |= UCA0RXIE;                         // Enable RX interrupt
    while(1){
        // FSM:  
        switch(state){
            case sleep_mode:

                __bis_SR_register(LPM0_bits + GIE);   // Enter LPM0
                 break;

            case ManualMotorControl:
                stepper_motor_manual_control();
                break;

            case JoystickPainter:
                Joystick_based_PC_painter();
                break;

            case calibration:
                stepper_motor_calibration();
                break;

            case ScriptMode:
                script_mode();
                break;

            case move_motor_freely:
                moving_stepper_motor();
                break;

            default:
                state = 0;
                break;
        }
    }
}
