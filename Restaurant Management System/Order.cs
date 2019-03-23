using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Restaurant_Management_System
{
    public partial class Order : Form
    {
        private OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\AL SYED\Documents\Restaurant.accdb");  
        public Order()
        {
            InitializeComponent();

            
        }
        public void hide() 
        {
            Chinesecb.Visible = false;
            Burgercb.Visible = false;
            Pizzacb.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Burgercb.SelectedIndex == 1 || Burgercb.SelectedIndex == 0 || Burgercb.SelectedIndex == 4)
            {
                Ammounttb.Text = "250";
            }
            else
            {
                Ammounttb.Text = "200";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButton1.Checked)
           {
               Burgercb.Visible = true;
           }
           else
           {
               hide();
           }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           if(radioButton2.Checked)
           {
               Pizzacb.Visible = true;
           }
           else
           {
               hide();
           }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
            if(radioButton3.Checked)
            {
            Chinesecb.Visible = true;
            }
            else
            {
                hide();
            }

        }
        
        private void Chinesecb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Chinesecb.SelectedIndex == 0 || Chinesecb.SelectedIndex==3) 
            {
                Ammounttb.Text = "350";
            }
            else
            {
                Ammounttb.Text = "450";
            }
        }

        private void Pizzacb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Pizzacb.SelectedIndex>=0 && Pizzacb.SelectedIndex>5)
            {
                Ammounttb.Text = "500";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Order (Name,Type,Mobile,Eat,Ammount) values ('" + nametb.Text + "','" + Chinesecb.Text + "','" + mobiletb.Text + "','" + eatcb.Text + "','" + Ammounttb.Text + "')";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your Food has ordered :)");
             }
                
              
            
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
           
        }
    }
}
