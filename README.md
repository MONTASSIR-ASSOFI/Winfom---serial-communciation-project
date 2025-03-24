# Winfom serial communciation project
Serial Communication use winforms C# and System.IO.SerialPort library 

This WinForms application uses a SerialPort to establish communication between a PC and an external device (like an Arduino) via a COM port (COM1 in this case). The user can input a message into textBox1, and when the button is clicked, the application sends the message over the serial connection. The data received from the serial port is displayed in textBox2. If the received message is "Q", the contents of textBox2 are cleared. The application runs at a baud rate of 9600.

Make sure that the device you are communicating with is correctly connected to the specified COM port, and that the baud rate is properly set on both ends for accurate communication.
