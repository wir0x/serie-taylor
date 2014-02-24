using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serieTaylor_Maclaurin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double factorial(double n)
        {
            if (n == 0)
                return n = 1;
            else 
                return n = n*factorial(n-1);
        }

        private double serie_t_m(double x)
        {
            double res = 0;    // Resultado 
            double tot = 0;     // Total
            double num;         // Numerador
            double den;         // Denominador
            for (int i = 1; i <= x; i++)
            {
                num = Math.Pow(x,i);
                den = factorial(i);
                tot = (num / den);
                res = res + tot;
            }
            return res + 1;
        }


        private string torre(int n)
        {
            int k;
            int c = n / 2;
            String trg = "";
            for (int i = 0; i <= c; i++)
            {
                k = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j >= c - i && j <= c + i)
                    {
                        trg += k + " ";
                        k++;
                    }
                    else
                    {
                        trg += 0 + " ";
                    }
                }
                trg += "\n";
            }
            return trg;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x = double.Parse(textBox1.Text);
                label2.Text = serie_t_m(x).ToString();
            }
            else
                MessageBox.Show("Error!!Ingrese un numero!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x = double.Parse(textBox1.Text);
                label2.Text = factorial(x).ToString();
            }
            else
                MessageBox.Show("Error!!Ingrese un numero!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (textBox1.Text != "")
            {
                int x = int.Parse(textBox1.Text);
                label4.Text = torre(x);
            }
            else
                MessageBox.Show("Error!!Ingrese un numero!");
        }
    }
}
