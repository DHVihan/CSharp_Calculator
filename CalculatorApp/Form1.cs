using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userinput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            function = '=';
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            function = 'C';
        }

        private void perButton_Click(object sender, EventArgs e)
        {
            function = '%';
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "0";
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "1";
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "2";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "5";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "6";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += "9";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            calculatorDisplay.Text += ".";
        }
    }
}
