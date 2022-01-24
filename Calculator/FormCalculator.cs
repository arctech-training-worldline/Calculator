using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        private int _operand1, _operand2;
        private char _calculatorOperator;
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            labelNumberDisplay.Text = CalculatorButtonPressed(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            labelNumberDisplay.Text = CalculatorButtonPressed(2);
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            _operand1 = int.Parse(labelNumberDisplay.Text);
            _calculatorOperator = '+';
            labelNumberDisplay.Text = "";
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            _operand2 = int.Parse(labelNumberDisplay.Text);
            int answer = 0;
            switch (_calculatorOperator)
            {
                case '+':
                    answer = _operand1 + _operand2;
                    break;
                case '-':
                    answer = _operand1 - _operand2;
                    break;
            }

            labelNumberDisplay.Text = answer.ToString();
        }

        private string CalculatorButtonPressed(int num)
        {
            // method 1
            //return int.Parse($"{labelNumberDisplay.Text}{num}").ToString();

            // method 2
            var text = $"{labelNumberDisplay.Text}{num}";
            if (text.StartsWith("0"))
                text = text.Substring(1);

            return text;
        }

        private void ButtonCe_Click(object sender, EventArgs e)
        {
            labelNumberDisplay.Text = "0";
        }
    }
}
