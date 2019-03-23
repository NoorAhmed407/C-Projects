using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class secondcustomcontrol : UserControl
    {
        public secondcustomcontrol()
        {
            InitializeComponent();
        }
        public void openorderform()
        {
            Order order = new Order();
            Visible = true;
            order.ShowDialog();
        }
        
        private void secondcustomcontrol_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openorderform();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openorderform();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            openorderform();
        }
    }
}
