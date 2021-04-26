using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelationalBoolean
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private string generate_randomOperator()
        {
            List<string> OperatorList = new List<string>();
            OperatorList.Add("==");
            OperatorList.Add("<=");
            OperatorList.Add(">=");
            OperatorList.Add(">");
            OperatorList.Add("<");

            int r = random.Next(0, 5);

            return OperatorList[r];
        }

        private string generate_random_SimpleBool()
        {
            var random = new Random();
            var firstVar = "x";
            var randomOperator = generate_randomOperator();
            int lastNum = random.Next(1, 300);
            string lastNumString = lastNum.ToString();

            string finalBool = "x " + randomOperator + " "+ lastNumString;

            return finalBool;
        }
        private void WinSequence()
        {
            int intScore = int.Parse(Score.Text);
            intScore++;
            BoolHolder.Text = generate_random_SimpleBool();
            Option1.Text = random.Next(0, 300).ToString();
            Option2.Text = random.Next(0, 300).ToString();
            Score.Text = intScore.ToString();

            FeedbackLabel.Text = "WIN!";
            FeedbackLabel.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void LoseSequence()
        {
            Score.Text = "0";
            BoolHolder.Text = generate_random_SimpleBool();
            Option1.Text = random.Next(0, 300).ToString();
            Option2.Text = random.Next(0, 300).ToString();

            FeedbackLabel.Text = "LOSE!";
            FeedbackLabel.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoolHolder.Text = generate_random_SimpleBool();
            Score.Text = "0";
            FeedbackLabel.Text = "";
            FeedbackLabel.ForeColor = Color.Black;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            BoolHolder.Text = generate_random_SimpleBool();
            Option1.Text = random.Next(0, 300).ToString();
            Option2.Text = random.Next(0, 300).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Score_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string currentBool = BoolHolder.Text;
            int optionNum = int.Parse(Option2.Text);
            string numToCompare = string.Empty;
            int value = 0;
            for (int i = 0; i < currentBool.Length; i++)
            {
                if (Char.IsDigit(currentBool[i]))
                {
                    numToCompare += currentBool[i];
                }
            }
            if (numToCompare.Length > 0)
            {
                value = int.Parse(numToCompare);
            }

            if (currentBool.Contains("<"))
            {
                if (optionNum < value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("<="))
            {
                if (optionNum <= value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">"))
            {
                if (optionNum > value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">="))
            {
                if (optionNum >= value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("=="))
            {
                if (optionNum == value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
        }

        private void NoneButton_Click(object sender, EventArgs e)
        {
            string currentBool = BoolHolder.Text;
            int optionNum1 = int.Parse(Option1.Text);
            int optionNum2 = int.Parse(Option2.Text);
            string numToCompare = string.Empty;
            int value = 0;
            for (int i = 0; i < currentBool.Length; i++)
            {
                if (Char.IsDigit(currentBool[i]))
                {
                    numToCompare += currentBool[i];
                }
            }
            if (numToCompare.Length > 0)
            {
                value = int.Parse(numToCompare);
            }

            if (currentBool.Contains("<"))
            {
                if (optionNum1 > value && optionNum2 > value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("<="))
            {
                if (optionNum1 > value && optionNum2 > value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">"))
            {
                if (optionNum1 < value && optionNum2 < value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">="))
            {
                if (optionNum1 < value && optionNum2 < value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("=="))
            {
                if (optionNum1 != value && optionNum2 != value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            string currentBool = BoolHolder.Text;
            int optionNum = int.Parse(Option1.Text);
            string numToCompare = string.Empty;
            int value = 0;
            for (int i=0; i < currentBool.Length; i++)
            {
                if (Char.IsDigit(currentBool[i]))
                {
                    numToCompare += currentBool[i];
                }
            }
            if (numToCompare.Length > 0)
            {
                value = int.Parse(numToCompare);
            }

            if(currentBool.Contains("<"))
            {
                if(optionNum < value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("<="))
            {
                if (optionNum <= value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">"))
            {
                if (optionNum > value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">="))
            {
                if (optionNum >= value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("=="))
            {
                if (optionNum == value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string currentBool = BoolHolder.Text;
            int optionNum1 = int.Parse(Option1.Text);
            int optionNum2 = int.Parse(Option2.Text);
            string numToCompare = string.Empty;
            int value = 0;
            for (int i = 0; i < currentBool.Length; i++)
            {
                if (Char.IsDigit(currentBool[i]))
                {
                    numToCompare += currentBool[i];
                }
            }
            if (numToCompare.Length > 0)
            {
                value = int.Parse(numToCompare);
            }

            if (currentBool.Contains("<"))
            {
                if (optionNum1 < value && optionNum2 < value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("<="))
            {
                if (optionNum1 <= value && optionNum2 <= value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">"))
            {
                if (optionNum1 > value && optionNum2 > value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains(">="))
            {
                if (optionNum1 >= value && optionNum2 >= value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
            else if (currentBool.Contains("=="))
            {
                if (optionNum1 == value && optionNum2 == value)
                {
                    WinSequence();
                }
                else
                {
                    LoseSequence();
                }
            }
        }
    }
}
