using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SerialPort sPort;

        public Form1()
        {
            InitializeComponent();

            foreach (var ports in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(ports);
            }
            

            //sPort = new SerialPort("COM3", 9600);
            //sPort.Open();       //Serial Port= sPort
            //sPort.DataReceived += SPort_DataReceived;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
        }

        private void SPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string s = sPort.ReadLine();
            this.BeginInvoke((new Action(delegate { showValue(s); })));
        }

        private void showValue(string s)
        {

            //pbts.Visible = true;
            //pbinout.Visible = true;
            //pbcall.Visible = true;

            //string s1 = s.Split('');
            //s = s[..^1];
            if (s == "User In")
            {
                label1.Text = "사용중";
                pictureBox1.BackColor = Color.Red;
            }
            else if (s == "User Out")
            {
                label1.Text = "사용가능";
                pictureBox1.BackColor = Color.Green;
            }
            else if (s == "Danger!")
            {
                label2.Text = "관리자 호출!";
                pictureBox2.BackColor = Color.Red;
            }
            else if (s == "")
            {
                label3.Text = "휴지가 충분합니다.";
                pictureBox3.BackColor = Color.Green;
            }
            else if (s == "Change!")
            {
                label3.Text = "휴지를 교체해주세요.";
                pictureBox3.BackColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            ComboBox cb = sender as ComboBox;
            sPort = new SerialPort(cb.SelectedItem.ToString());
            sPort.Open();
            sPort.DataReceived += SPort_DataReceived;
        }

        private void pninout1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
 }


