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
            // para makapag initiate
            cal = new CalculatorClass();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/", "%", "^" });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;

            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            Console.WriteLine("First Number:" + num1);
            Console.WriteLine("Second:" + num2);
        }
    }
}
