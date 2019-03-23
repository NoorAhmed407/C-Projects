using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = button1.Height;
            firstcustomcontrol1.BringToFront();
            sidepanel.Top = button1.Top;
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void firstcustomcontrol1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            firstcustomcontrol1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            secondcustomcontrol1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/noor.qureshi.12");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.twitter.com");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            thirdcustomcontrol1.BringToFront();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            fourthcustomcontrol1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            fifthcustomcontrol1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button6.Height;
            sidepanel.Top = button6.Top;
            sixthcustomcontrol1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button7.Height;
            sidepanel.Top = button7.Top;
            seventhcustomcontrol1.BringToFront();
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Visible = false;
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
