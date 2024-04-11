using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        private string wordToGuess = "integrative";
        private List<string> wrongGuesses = new List<string>();
        public frmGuessWord()
        {
            InitializeComponent();
            label1.Text = "Word to Guess: ";
            InitializedGuessingWord();
        }
        private void InitializedGuessingWord()
        {
            StringBuilder wordToGuess = new StringBuilder();
            wordToGuess.Append(this.wordToGuess[0]);
            for (int i = 1; i < this.wordToGuess.Length - 1; i++)
            {
                wordToGuess.Append('?');
            }
            wordToGuess.Append(this.wordToGuess[this.wordToGuess.Length - 1]);
            label1.Text += wordToGuess.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string guessedWord = textBox1.Text.ToLower();

            if (guessedWord == wordToGuess)
            {
                label1.Text = $"Correct! The word was {wordToGuess}.";
            }
            else
            {
                wrongGuesses.Add(guessedWord);
                UpdateWrongGuessList();
            }
        } 
            private void UpdateWrongGuessList()
            {
                StringBuilder sBuilder = new StringBuilder();
                foreach (string wrongGuess in wrongGuesses)
                {
                    sBuilder.Append(wrongGuess);
                    sBuilder.Append(Environment.NewLine);
                }
                label3.Text = sBuilder.ToString();
            }
        }
    }