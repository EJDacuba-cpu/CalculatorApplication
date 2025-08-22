using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        // pag declare ng variables
        CalculatorClass cal;
        public Form1()
        {
            InitializeComponent();
            // para makapag initiate sa class na CalculatorcClass.cs
            cal = new CalculatorClass();
            // para may operator na agad kapag binuksan ang combobox
            comboBox1.SelectedIndex = 0;
   

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            //pagkuha ng values na nakalagay sa textbox at iconvert sa double
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            double result = 0;
            string op = comboBox1.SelectedItem?.ToString();//para sa pagkuha nang napiling operator

            if (op == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                result = cal.GetSum(num1, num2);
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (op == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                result = cal.GetDifference(num1, num2);
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (op == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                result = cal.GetProduct(num1, num2);
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (op == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.Getquotient);
                result = cal.Getquotient(num1, num2);
                cal.CalculateEvent -= new Formula<double>(cal.Getquotient);
            }

            label3.Text = result.ToString();
        }
    }
}
