namespace MyWinFormsApp;
using System.IO.Ports;
public partial class Form1 : Form
{
	static string Message =  "" ;
	SerialPort serialPort = new SerialPort("COM1", 9600);
    public Form1()
    {
        InitializeComponent();
		serialPort.Open();
    }
    
	void Button1Click(object sender, EventArgs e)
	{           
			serialPort.WriteLine(Message);
	}
		
    void TextBox1TextChanged(object sender, System.EventArgs e)
	{
			Message = textBox1.Text ;
			
	}		

		
	 private void DataReceivedHandler(
                        object sender,
                        SerialDataReceivedEventArgs e)
    {
        SerialPort sp = (SerialPort)sender;
        string indata = sp.ReadExisting();
		if(indata == "Q"){
           textBox2.Text ="";
        }else{
		   textBox2.Text += indata ;
		}
	}
}
