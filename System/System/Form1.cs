using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 c = new Form8();
            c.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 b = new Form2();
            b.ShowDialog();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f = new Form10();
            f.ShowDialog();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 v = new Form9();
            v.ShowDialog();

        }
    }
}
