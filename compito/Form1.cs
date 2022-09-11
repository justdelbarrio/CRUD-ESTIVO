﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Visible = false;
            form2.ShowDialog();
            this.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "admin")
            {
                Form4 form4 = new Form4();
                this.Visible = false;
                form4.ShowDialog();
                this.Visible = true;
            }
            else
            {
                textBox2.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
