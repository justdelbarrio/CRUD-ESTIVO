using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void componi()
        {
            string x;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                try
                {
                    float y = Convert.ToInt16(textBox2.Text);
                    string sep = ";";
                    x = textBox1.Text + sep + textBox2.Text + sep + textBox3.Text + sep + textBox4.Text + sep + "True";

                    Scrittura(x);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Inserire un costo corretto");
                }
            }
        }
        public void Scrittura(string x)
        {
            using (StreamWriter sw = File.AppendText("./Menu.txt"))
            {
                sw.WriteLine(x);
            }
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            componi();
        }
    }
}
