using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show(" Вы не ввели значения операндов.","EROR" );
                return;
            }
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (radioButton1.Checked)
            {
                textBox3.Text = (a + b).ToString();
            }
            else if (radioButton2.Checked)
            {
                textBox3.Text = (a - b).ToString();
            }
            else if (radioButton3.Checked)
            {
                textBox3.Text = (a * b).ToString();
            }
            else if (radioButton4.Checked)
            {
                if (b == 0)
                {
                    MessageBox.Show(" На ноль делить нельзя! ");
                }
                else
                {
                    textBox3.Text = (a / b).ToString();
                }
            }
            else
            {
                MessageBox.Show(" Вы не выбрали операцию. ");
            }
        }
        
    }
}
