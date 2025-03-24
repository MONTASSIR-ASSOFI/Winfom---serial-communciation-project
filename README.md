# Winfom serial communciation project
### Serial Communication use winforms C# and System.IO.SerialPort library 

This WinForms application uses a SerialPort to establish communication between a PC and an external device (like an Arduino) via a COM port (COM1 in this case). The user can input a message into textBox1, and when the button is clicked, the application sends the message over the serial connection. The data received from the serial port is displayed in textBox2. If the received message is "Q", the contents of textBox2 are cleared. The application runs at a baud rate of 9600.

# testing 

For testing, you can use a Virtual COM Port Emulator to simulate serial communication between virtual devices. Download a virtual port emulator like Virtual Serial Port Driver to create virtual COM ports for communication.

Additionally, you can use Tera Term to test and monitor serial communication. Tera Term is a free software terminal emulator that supports serial ports. You can download it here: Tera Term Download.
