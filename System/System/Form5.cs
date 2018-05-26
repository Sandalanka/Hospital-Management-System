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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\User\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox1.Text);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into doctor(doctorID,Name,Subject,Days,Time) values('" + id + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                display();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            public void display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from doctor";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

            private void Form5_Load(object sender, EventArgs e)
            {
                display();
            }

            private void button2_Click(object sender, EventArgs e)
            {
                try{
                    int id = Convert.ToInt32(textBox1.Text);
                conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from doctor where doctorID='"+id+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            display();
            }
                catch(Exception ex){
                    MessageBox.Show(ex.Message);

                }
        }

            private void button3_Click(object sender, EventArgs e)
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update doctor set ='" + textBox2.Text + "' where ='" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    display();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void button4_Click(object sender, EventArgs e)
            {
                try
                {
                    int id = Convert.ToInt32(textBox1.Text);
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select*from doctor where doctorID='" +id + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            private void button6_Click(object sender, EventArgs e)
            {
                this.Hide();
                Form1 v = new Form1();
                v.ShowDialog();
            }
            }

        }
    

