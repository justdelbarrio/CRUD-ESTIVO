using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./Menu.txt");
            string k = textBox1.Text;
            string n = null;
            string x = sr.ReadLine();
            while (x != null)
            {
                if (k == x.Split(';')[0])
                {
                    if(checkBox1.Checked == true)
                    {
                        n += textBox2.Text;
                    }
                    else
                    {
                        n += x.Split(';')[0];
                    }
                    n += ";";
                    if (checkBox2.Checked == true)
                    {
                        n += textBox3.Text;
                    }
                    else
                    {
                        n += x.Split(';')[1];
                    }
                    n += ";";
                    if (checkBox3.Checked == true)
                    {
                        n += textBox4.Text;
                    }
                    else
                    {
                        n += x.Split(';')[2];
                    }
                    n += ";";
                    if (checkBox4.Checked == true)
                    {
                        n += textBox5.Text;
                    }
                    else
                    {
                        n += x.Split(';')[3];
                    }
                    n += ";" + x.Split(';')[4];
                    
                }
                x = sr.ReadLine();
            }
            
            sr.Close();
            StreamReader sr1 = new StreamReader("./Menu.txt");
            string stampareale = null;
            x = "";
            while (x != null)
            {
                x = sr1.ReadLine();
                if (x != null)
                {
                    string z = x;
                    if (x.Split(';')[0] != textBox1.Text)
                    {
                        stampareale += z;
                        stampareale += "\n";
                    }
                    else
                    {
                        stampareale += n;
                        stampareale += "\n";
                    }
                }
            }
            sr1.Close();

            File.WriteAllText("./Menu.txt", stampareale);
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
