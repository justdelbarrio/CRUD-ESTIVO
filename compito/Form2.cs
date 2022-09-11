using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compito
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string[] list = new string[1000];
        
        private void Form2_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./Menu.txt"); ;
            string basta = sr.ReadLine();

            int count = 0;

            while (basta != null)
            {
                if (basta.Split(';')[4] == "True")
                {
                    list[count] = $"Nome: {basta.Split(';')[0]}\tPrezzo: €{basta.Split(';')[1]} \tIngredienti: {basta.Split(';')[2]}\tPortata: {basta.Split(';')[3]}";
                    listBox1.Items.Add(list[count]);
                }
                basta = sr.ReadLine();
                count++;
            }
            sr.Close();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(x);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] w = new string[listBox2.Items.Count+1];

            for(int i = 0; i < listBox2.Items.Count; i++)
            {
                string x = listBox2.Items[i].ToString();
                for(int r =0;r < x.Length; r++)
                {
                    if (x[r] == '€')
                    {
                        for(int z = r; x[z] != ' '; z++)
                        {
                            w[i] += x[z];
                        }
                    }
                }
            }
            decimal[] Somma = new decimal[listBox2.Items.Count];
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                w[i] = w[i].Substring(1);
                Somma[i] = Convert.ToDecimal(w[i]);
            }
            label3.Text = Convert.ToString(Somma.Sum());
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        
    }
}
