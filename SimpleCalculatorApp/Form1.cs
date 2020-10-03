using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum1);

            int num1 = Int32.Parse(txtnum1.Text);
            int num2 = Int32.Parse(txtnum2.Text);

            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum2);

            int num1 = Int32.Parse(txtnum1.Text);
            int num2 = Int32.Parse(txtnum2.Text);

            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum3);

            int num1 = Int32.Parse(txtnum1.Text);
            int num2 = Int32.Parse(txtnum2.Text);

            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetAnswer delegateAnswer = new GetAnswer(Formula.getSum4);

            int num1 = Int32.Parse(txtnum1.Text);
            int num2 = Int32.Parse(txtnum2.Text);

            MessageBox.Show(delegateAnswer(num1, num2).ToString());
        }
    }
}
