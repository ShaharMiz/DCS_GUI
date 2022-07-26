// HAL - Hardware Abstraction Layer

#ifndef _hal_H_
#define _hal_H_


extern volatile unsigned int state;
#define sleep_mode         0
#define ManualMotorControl 1
#define JoystickPainter    2
#define calibration        3
#define ScriptMode         4
#define move_motor_freely  5

// Joy Stick modes
#define neutral 1
#define draw    2
#define erase   3
#define none    4
#define origin  460   // (0,0) of x-y
#define radius_min 455
#define radius_max 460
#define radius_min_bruto 100
#define radius_max_bruto 900
#define PI 3.14159265

#define Phi_deg 175

//================================================
//                     UART
//================================================
//------------------------------------------------
//                  Variables
//------------------------------------------------
extern unsigned int state_flg;
//  state defines
#define State_Msg_Size = 4; // 2- State, 2- State_Stage, without '#'

// stage state defines
#define no_action 0
#define start_move_forwards 1
#define start_move_backwards 2
#define stop_motor 3

//  status defines
#define Status_Msg_Size = 40;
//------------------------------------------------
//              SERVICE FUNCTIONS
//------------------------------------------------
extern void GatherStatusInfo(void);
extern void enable_transmition(void);
__interrupt void USCI0RX_ISR(void);
__interrupt void USCI0TX_ISR(void);
//================================================
//                 Joy Stick
//================================================
//------------------------------------------------
//                  Variables
//------------------------------------------------
extern volatile unsigned int Vx;
extern volatile unsigned int Vy;
extern volatile unsigned long destiny_angle;
//------------------------------------------------
//              SERVICE FUNCTIONS
//------------------------------------------------
__interrupt void ADC10_ISR(void);
__interrupt void PORT1_ISR(void);
extern void sampleVxy(void);
extern void MoveToJoyStickDiraction(void);

//================================================
//                Stepper Motor
//================================================
//------------------------------------------------
//                  Variables
//------------------------------------------------
extern volatile int SM_Step;
extern volatile int SM_Half_Step;
extern volatile int StepperDelay;

extern volatile unsigned long Left_ang;
extern volatile unsigned long Right_ang;
extern volatile long Dist_in_degree;
extern volatile int Got_to_left_flg;
extern volatile int Got_to_right_flg;
extern volatile scan_mode;
//------------------------------------------------
//              SERVICE FUNCTIONS
//------------------------------------------------
void step_angle_update(void);
extern void move_forward(void);
extern void move_backward(void);
extern void move_forward_half(void);
extern void move_backward_half(void);



void stepper_scan(unsigned long l, unsigned long r);

void move_to_angle(unsigned long angle);
void forward(void);
void backward(void);

void scan_to_right(void);

void stepper_deg(unsigned long);
//================================================
//            State 3 - calibration
//================================================
//------------------------------------------------
//                  Variables
//------------------------------------------------
extern volatile unsigned long Phi;
//------------------------------------------------
//              SERVICE FUNCTIONS
//------------------------------------------------
extern void Phi_calculation(void);

//================================================
//             State 4 - Script Mode
//================================================
//------------------------------------------------
//          Flash memory configuration
//------------------------------------------------
#define FLASH_INFO_SEG_B_START     (char*)0xF800
#define FLASH_INFO_SEG_B_END       (char*)0xF9FF

#define FLASH_INFO_SEG_C_START     (char*)0xFA00
#define FLASH_INFO_SEG_C_END       (char*)0xFBFF

#define FLASH_INFO_SEG_D_START     (char*)0xFC00
#define FLASH_INFO_SEG_D_END       (char*)0xFDFF

//------------------------------------------------
//                  Variables
//------------------------------------------------
extern volatile int opcode;
extern volatile int ScriptNumFlg;
extern volatile char ScriptNum;
extern int script_size_counter;
extern int script_idx;

typedef struct Scripts{
    int written[3];
    char *pscript[3];
    int size[3];
    int lines[3];
    int num_script;
    int first_written[3];
}Scripts;
//------------------------------------------------
//              SERVICE FUNCTIONS
//------------------------------------------------
extern void clear_RGB(void);
extern void blink_RGB(int delay, int times);
extern void clear_RGB(void);
extern volatile int Out_to_RGB; // state 4

extern Scripts s;
extern int ScriptModeDelay;
extern int write_to_flash;
extern int offset;

volatile int num_byte;
extern int get_x_value(void);

extern int receive_int(void);
extern void receive_string(int *data);
extern void send_ack(void);


void write_seg (char* flash_ptr);
char read_char(char address);
int read_mem(int offset);
void blink_rgb(int delay, int times);

// rotate functions
#define left_rotate 1
#define right_rotate 2

extern volatile int first_rotate;
extern volatile int PortNum;
extern volatile int LEDs_val_P1;
extern volatile int LEDs_val_P2;
extern volatile int last_rotate;
void rlc_leds(int delay, int times);
void rrc_leds(int delay, int times);

extern volatile char p_rx[10];
extern int index;

extern void StopTimers();
extern void Timer0_A_delay_ms(int ms);
extern void Timer1_A_delay_10ms(int ms);
//================================================
//                  Delay [ms]
//================================================
__interrupt void Timer0_A0(void);
__interrupt void Timer0_A1(void);


#endif
