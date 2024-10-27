using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork5
{
    public partial class Form1 : Form
    {
        private int randomNumber;
        private int guessCount;

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        private void StartNewGame()
        {
            Random rand = new Random();
            randomNumber = rand.Next(1, 101);
            label2.Text = "Guess number between 1 and 100";
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        {
            int userGuess;
            if (int.TryParse(textBox1.Text, out userGuess))
            {
                guessCount++;
                if (userGuess > randomNumber)
                {
                    label2.Text = "Too high";
                }
                else if (userGuess < randomNumber)
                {
                    label2.Text = "Too low";
                }
                else
                {
                    label2.Text = $"Congratulations! You guessed the number in {guessCount} tries.";

                }
            }
            else
            {
                label2.Text = "Please enter a valid number!";
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

