using System;
using System.Windows.Forms;

namespace Nederlands_naar_Morse_code_en_vice_versa
{
    public partial class Form1 : Form
    {
        string[] alphabet = new string[] {" ","a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
        string[] morseAlphabet = new string[] {"/",".-","-...","-...","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.", "--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonToMorse_Click(object sender, EventArgs e)
        {
            string input = TextBoxInput.Text;
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                string inputLetter = input[i].ToString();
                for (int y = 0; y < alphabet.Length; y++)
                {
                    if (inputLetter.ToLower() == alphabet[y])
                    {
                        if (output.Length > 0)
                            output += " ";
                       output += morseAlphabet[y];
                    }
                }
            }
            TextBoxInput.Text = output;
        }
        private string refMorseTable(string subString, string output)
        {
            for (int i = 0; i < morseAlphabet.Length; i++)
            {
                if (subString == morseAlphabet[i])
                {
                    output += alphabet[i];
                    break;
                }
            }
            return output;
        }

        private string myRecur(string input, string output)
        {
            //MessageBox.Show("String input = " + input);
            int space = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == " ")
                {
                    space = i;
                    break;
                }
            }
            string subInput = "";
            if (space == 0)
            {
                subInput = input;
                output = refMorseTable(subInput, output);
                return output;
            }
            else
                subInput = input.Substring(0, space);
            //MessageBox.Show("substring = " + subInput);
            output = refMorseTable(subInput, output);
            //MessageBox.Show(input.Length.ToString());
            //MessageBox.Show("To give " + input.Substring(space+1));
            return myRecur(input.Substring(space+1), output);
        }

        private void ButtonToNL_Click(object sender, EventArgs e)
        {
            string input = TextBoxInput.Text;
            string output = myRecur(input, "");
          
            MessageBox.Show("OUTPUT = " + output);
            TextBoxInput.Text = output;
        }
    }
}
