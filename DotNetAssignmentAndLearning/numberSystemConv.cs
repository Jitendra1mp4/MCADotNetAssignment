using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DotNetAssignmentAndLearning
{
    public partial class des : Form
    {


        class NumberSystem
        {

           internal NumberSystem(int Base, string Name) { 
             this.Name = Name;
             this.Base = Base;
            }

            public string Name { get; set; } 
            public int Base { get; set; }
        }


        public des()
        {
            InitializeComponent();
        }

        List<NumberSystem> statesForFrom;
        List<NumberSystem> statesForTo;
        private void des_Load(object sender, EventArgs e)
        {
            statesForFrom = new List<NumberSystem>
            {
                new NumberSystem(2, "Binary"),
                new NumberSystem(8, "Octal"),
                new NumberSystem(10, "Decimal"),
                new NumberSystem(16, "HexaDecimal")
            };

            statesForTo = new List<NumberSystem>
            {
                new NumberSystem(2, "Binary"),
                new NumberSystem(8, "Octal"),
                new NumberSystem(10, "Decimal"),
                new NumberSystem(16, "HexaDecimal")
            };


            fromNumberSystem.DataSource = statesForFrom;
            fromNumberSystem.DisplayMember= "Name";
            fromNumberSystem.ValueMember = "Base"; 
            fromNumberSystem.SelectedIndex = 0;

            toNumberSystem.DataSource = statesForTo;
            toNumberSystem.DisplayMember = "Name";
            toNumberSystem.ValueMember = "Base";
            toNumberSystem.SelectedIndex= 0;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convert();
        }

        void Convert()
        {
            string from = fromNumberSystem.Text.ToString();
            string to = toNumberSystem.Text.ToString();

            if (from == to ) { outputTextBox.Text = inputTextBox.Text; return; }

            if (inputTextBox.Text == "") {outputTextBox.Text = ""; return; }

            try
            {
                int Base = int.Parse(fromNumberSystem.SelectedValue.ToString());
                string dec = GetDecimalFromBase(Base, inputTextBox.Text.ToUpper()).ToString();

                switch (to)
                {
                    case "Decimal": outputTextBox.Text = dec; break;
                    case "Binary": outputTextBox.Text = FromDecimalGetBase(2, int.Parse(dec)); break;
                    case "Octal": outputTextBox.Text = FromDecimalGetBase(8, int.Parse(dec)); break;
                    case "HexaDecimal": outputTextBox.Text = FromDecimalGetBase(16, int.Parse(dec)); break;
                }

            }
            catch (Exception ex) { 
             Console.WriteLine(ex.Message);
              
            listBox1.Items.Add("occured ex:"+ex.Message);
            }
   
        }


        int GetDecimalFromBase(int nsBase ,string numberString)
        {

            numberString = numberString.ToUpper();

            int result = 0;

            int position = 0;
            for (int i = numberString.Length - 1; i >= 0; i--)
            {

                int weight = (int)Math.Pow(nsBase,position);

                string s = numberString[i].ToString() ;

                if (nsBase == 16 && numberString[i] >= 'A' && numberString[i] <= 'F')
                {
                 s = getIntForAlpha(numberString[i]).ToString();
                }

                result += int.Parse(s) * weight;
                
                position++;
            }
            return result;
        }





        string FromDecimalGetBase(int nsBase, int decimalNumber)
        {
            if (decimalNumber == 0) return "0";

            int copy = decimalNumber;

            string result = "";

            while (copy > 0) { 
                int digit = copy % nsBase;

                if (nsBase == 16 && digit >= 10)
                    result = getAlphaForHex(digit).ToString() +result;
                else
                    result = digit.ToString() + result;

                copy /= nsBase;
            }

            return result;
        }


        char getAlphaForHex(int integer)
        {
            char a = (char)('A' + (integer % 10));
            return a; 
        }

        int getIntForAlpha(char alpha)
        {
            int hex = (int)(alpha - 'A' + 10);
            return hex; 
        }

        private void toNumberSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            Convert();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Convert();
        }
    }
}
