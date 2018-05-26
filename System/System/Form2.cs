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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int nic, mnumber;
                nic = Convert.ToInt32(textBox1.Text);
                mnumber = Convert.ToInt32(textBox4.Text);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into patients(NIC,first,second,mobile,EmailAddress,address) values('"+nic+ "','" + textBox2.Text + "','" + textBox3.Text + "','"+mnumber+"','"+textBox5.Text+"','"+textBox6.Text+"')";
                cmd.ExecuteNonQuery();
                conn.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(textBox7.Text);
                int age = Convert.ToInt32(textBox8.Text);
                int weight = Convert.ToInt32(textBox9.Text);
                int height = Convert.ToInt32(textBox10.Text);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into medical(NIC,Age,weight,height,diseases) values('" + id + "','" + age + "','" + weight + "','"+height+"','"+textBox11.Text+"')";
                cmd.ExecuteNonQuery();
                conn.Close();
               
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 v = new Form1();
            v.ShowDialog();

        }
    }
}
