using System;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public int[] Arrayy = new int[10];
        public int n = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (n!= 10)
            {
                if (Int32.TryParse(textBox1.Text, out Arrayy[n]))
                {
                    n++;
                    richTextBox1.Text = 1 + ". " + Arrayy[0] + "\n";
                    for (int i = 1; i < n; i++)
                    {
                        richTextBox1.AppendText(i + 1 + ". " + Arrayy[i] + "\n");
                    }
                }
            }
            else
            {
                richTextBox1.Text = "";
                n = 0;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (n == 10)
            {
                int suma = 0;
                for (int i = 0; i < 10; i++)
                {
                    suma += Arrayy[i];
                }
                richTextBox1.Text = "suma = " + suma;
            }
            else
            {
                form2 = new Form2();
                form2.Show();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int Dydis;
            string layer = textBox2.Text;
            if (Int32.TryParse(textBox2.Text, out Dydis) && Dydis > 0)
            {
                richTextBox2.Text = "";
                int zvaigz = 1;
                int a = Convert.ToInt32(layer);
                int layers = a;
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < layers; j++)
                    {
                        richTextBox2.Text += " ";
                    }
                    for (int j = 0; j < zvaigz; j++)
                    {
                        richTextBox2.Text += "* ";
                    }
                    richTextBox2.Text += "\n";
                    zvaigz++;
                    layers--;
                }
            }
        }
    }
}
