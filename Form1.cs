using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            comboBox1.Text = "Select Port";

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
            pbts.Visible = true;
            pbinout.Visible = true;
            pbcall.Visible = true;

            if (s == "")
            {
                //첫번째 변기 휴지와의 거리
                label3.Text = "휴지가 충분합니다.";
                pnts.BackColor = Color.Green;
            }
            else if (s == "Change!")
            {
                label3.Text = "휴지를 교체해주세요.";
                pnts.BackColor = Color.Red;
            }
            if (s == "User In")
            {
                //첫번째 변기 출입여부
                pninout1.BackColor = Color.Red;
                label1.Text = "사용중";
            }
            else if (s == "User Out")
            {
                pninout1.BackColor = Color.Green;
                label1.Text = "사용가능";
            }
            if (s == "Danger!")
            {
                pncall1.BackColor = Color.Red;
                label2.Text = "관리자 호출!";
            }
            else if (s == "?")
            {
                pncall1.BackColor = Color.White;
                label2.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            sPort = new SerialPort(cb.SelectedItem.ToString());
            sPort.Open();
            sPort.DataReceived += SPort_DataReceived;
        }
    }
 }


