using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace System
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 v = new Form1();
            v.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*)from table1 where username='" + textBox1.Text + "' and password='" + textBox2.Text+ "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    this.Hide();
                    Form4 b = new Form4();
                    b.ShowDialog();
                }
                else
                {
                    MessageBox.Show("TRy Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Try Agin");
            }

        }
    }
}
