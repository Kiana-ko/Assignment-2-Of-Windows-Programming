using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MorseCodeConvertor


{
    public partial class Form1 : Form
    {
        private Dictionary<char, string> morseCodeDictionary;
        public Form1()
        {
            InitializeComponent();
           morseCodeAdder();
        }

        private void morseCodeAdder()
        {
            morseCodeDictionary = new Dictionary<char, string>
            {
                {'A', ".-"}, {'B', "-..."}, {'C', "-.-."}, {'D', "-.."}, {'E', "."},
                {'F', "..-."}, {'G', "--."}, {'H', "...."}, {'I', ".."}, {'J', ".---"},
                {'K', "-.-"}, {'L', ".-.."}, {'M', "--"}, {'N', "-."}, {'O', "---"},
                {'P', ".--."}, {'Q', "--.-"}, {'R', ".-."}, {'S', "..."}, {'T', "-"},
                {'U', "..-"}, {'V', "...-"}, {'W', ".--"}, {'X', "-..-"}, {'Y', "-.--"},
                {'Z', "--.."}, {'0', "-----"}, {'1', ".----"}, {'2', "..---"},
                {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."},
                {'7', "--..."}, {'8', "---.."}, {'9', "----."}
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.ToUpper();
            string output = ConvertToMorseCode(input);
            textBox1.Text = output;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private string ConvertToMorseCode(string userInput)
        {
            string morseCode = "";
            foreach (char c in userInput)
            {
                if (morseCodeDictionary.ContainsKey(c))
                {
                    morseCode += morseCodeDictionary[c] + " ";
                }
                else if (c == ' ')
                {
                    morseCode += "/ ";
                }
                else
                {
                    morseCode += c + " ";
                }
            }
            return morseCode;
        }
    }
}