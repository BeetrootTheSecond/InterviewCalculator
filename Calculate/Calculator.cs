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
            Multiply = '*',
            Divide = '/'
        };
        Operators CurrentOperator = Operators.Add;
        
        public int MyUserInteger;

        public Calculator()
        {// set default radio button 
            InitializeComponent();
            //radioButton1.Checked = true;
        }
                

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //clears result text box
            ResultTXT.Text = "";
            
            for (int i = 1; i < 13;i++) 
            {
                ResultTXT.Text+= generateText(i, MyUserInteger, CurrentOperator);
            }
        }

        private string generateText(int i, int userInput, Operators Operator)
        {
            int result=0;
            
            switch (Operator)
            {
                case Operators.Add:
                    result = i + userInput;
                    break;
                case Operators.Subtract:
                    result = i - userInput;
                    break;
                case Operators.Multiply:
                    result = i * userInput;
                    break;
                case Operators.Divide:
                    result = i / userInput;
                    break;
            }
         //Formats the output 
            return string.Format("{0} {1} {2} = {3} ", i, (char)Operator, userInput, result) + Environment.NewLine;
        }


        private void UserInputTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                MyUserInteger = int.Parse(UserInputTXT.Text);
                if (MyUserInteger < 11 && MyUserInteger > 0)
                    CalculateButton.Enabled = true;
                else
                    throw new ArgumentOutOfRangeException();
            }
            catch (Exception _exception)
            {
                CalculateButton.Enabled = false;
            }
        }
        
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
