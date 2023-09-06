using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace прак_15
{
    public partial class Form1 : Form
    {
        double firstNum;
        double result;
        private string operation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void numberButton_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (ResultTextBox.Text == "0")
            {
                ResultTextBox.Text = but.Text;
            }
            else
            {
                ResultTextBox.Text += but.Text;
            }            
        }
        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button ton = (Button)sender;
            operation = ton.Text;
            firstNum = Double.Parse(ResultTextBox.Text);
            label1.Text = ResultTextBox.Text + operation;
            ResultTextBox.Clear();
        }
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + ResultTextBox.Text;
            switch (operation)
            {
                case "+":
                    result = (firstNum + Double.Parse(ResultTextBox.Text));
                    break;
                case "-":
                    result = (firstNum - Double.Parse(ResultTextBox.Text));
                    break;
                case "*":
                    result = (firstNum * Double.Parse(ResultTextBox.Text));
                    break;
                case "/":
                    result = (firstNum / Double.Parse(ResultTextBox.Text));
                    break;
                default:
                    break;
            }
            string res = result.ToString();
            ResultTextBox.Clear();
            ResultTextBox.Text = res;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            label1.Text = "";
        }
        private void delButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = ResultTextBox.Text.Substring(0, ResultTextBox.Text.Length - 1);
            if (ResultTextBox.Text == "")
            {
                ResultTextBox.Text = "0";
            }
        }

        private void button_Dot_Click(object sender, EventArgs e)
        {
            if (!ResultTextBox.Text.Contains(","))
            {
                ResultTextBox.Text += ",";
            }
        }
    }
}
