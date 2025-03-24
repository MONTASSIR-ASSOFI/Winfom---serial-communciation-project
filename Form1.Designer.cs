namespace MyWinFormsApp;
using System.IO.Ports;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SteelBlue;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(553, 106);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(102, 55);
			this.button1.TabIndex = 0;
			this.button1.Text = "send";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkCyan;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(697, 45);
			this.panel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(24, 9);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(375, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "serial communication";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
			this.panel2.Location = new System.Drawing.Point(0, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(141, 423);
			this.panel2.TabIndex = 4;

			this.serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel3.Location = new System.Drawing.Point(0, 45);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(185, 463);
			this.panel3.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(208, 58);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(339, 45);
			this.label3.TabIndex = 5;
			this.label3.Text = "send data serial :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(234, 106);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 128);
			this.textBox1.TabIndex = 6;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(219, 254);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(257, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "receive data :";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.Location = new System.Drawing.Point(219, 290);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(448, 135);
			this.textBox2.TabIndex = 9;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(697, 427);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "serial communication";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
			private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
    }

    #endregion

