using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculate
{
    public partial class Calculator : Form
    {
        enum Operators
        {
            Add = '+',
            Subtract = '-',
            Multiply = 'x',
            Divide = '÷'
        };
        Operators CurrentOperator = Operators.Add;
        
        public int MyUserInteger;

        public Calculator()
        { 
            InitializeComponent();
        }
                

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //clears result text box
            ResultTXT.Text = string.Empty;
            
            //prints the calculations for 1 to 12
            for (int i = 1; i < 13;i++) 
            {
                ResultTXT.Text+= GenerateText(i, MyUserInteger);
            }
        }

        private string GenerateText(int i, int userInput)
        {
            //Formats the output to show the iterative(i) then the Operator and userInput followed by the result of the 
            return string.Format("{0} {1} {2} = {3} ", i, (char)CurrentOperator, userInput, Calculate(i, userInput)) + Environment.NewLine;
        }

        // Apply operator to values
        private int Calculate(int a, int b)
        {
            switch (CurrentOperator)
            {
                case Operators.Add:
                    return a + b;
                case Operators.Subtract:
                    return a - b;
                case Operators.Multiply:
                    return a * b;
                // Operators.Divide
                default: 
                    return a / b;
            }
        }


        private void UserInputTXT_TextChanged(object sender, EventArgs e)
        {
            //Check MyUserinput is an integer and between 1 and 10, unexpected values are handled by exceptions
            try
            {
                MyUserInteger = int.Parse(UserInputTXT.Text);
                if (MyUserInteger > 0 && MyUserInteger < 11)
                    CalculateButton.Enabled = true;
                else
                    throw new ArgumentOutOfRangeException();
            }
            catch (Exception _exception)
            {
                CalculateButton.Enabled = false;
            }
        }
        

        //Updates the current operator when a new radio button is selected
        private void AddRB_CheckedChanged(object sender, EventArgs e)
        {
            if (AddRB.Checked)
                CurrentOperator = Operators.Add;
        }

        private void SubstractRB_CheckedChanged(object sender, EventArgs e)
        {
            if(SubstractRB.Checked)
                CurrentOperator = Operators.Subtract;
        }

        private void DivideRB_CheckedChanged(object sender, EventArgs e)
        {
            if (DivideRB.Checked)
                CurrentOperator = Operators.Divide;
        }

        private void MultipleRB_CheckedChanged(object sender, EventArgs e)
        {
            if (MultipleRB.Checked)
                CurrentOperator = Operators.Multiply;
        }
    }
}
