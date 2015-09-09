using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch.Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour, min, sec, ms = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayTimer(label1);
            ms++;
             
            if (ms == 10)
            {
                sec++;
                ms = 0;
            }
                
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            
            if (min == 60)
            {
                hour++;
                min = 0;
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            ms = 0;
            sec = 0;
            min = 0;
            hour = 0;
            DisplayTimer(label1);
            
        }

        private void DisplayTimer(Label timerDisplay)
        {
            timerDisplay.Text = hour + ":" + min + ":" + sec + ":" + ms.ToString();
            //test
        }

    }
}
