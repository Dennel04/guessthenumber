using System;
using System.Windows.Forms;

namespace ass5
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int guessCount;

        public Form1()
        {
            InitializeComponent();
            GenerateRandomNumber();
        }

        private void GenerateRandomNumber()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);
            guessCount = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userGuess;

            if (int.TryParse(textBox1.Text, out userGuess))
            {
                if (userGuess < 1 || userGuess > 100)
                {
                    MessageBox.Show("Please enter a number between 1 and 100.");
                    return;
                }

                guessCount++;

                if (userGuess > randomNumber)
                {
                    MessageBox.Show("Too high a number! Try again.");
                }
                else if (userGuess < randomNumber)
                {
                    MessageBox.Show("Too low a number! Try again.");
                }
                else
                {
                    MessageBox.Show($"Congratulations! You guessed the number after {guessCount} tries.");
                    GenerateRandomNumber();
                    textBox1.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please, enter a valid number!");
            }
        }
    }
}
