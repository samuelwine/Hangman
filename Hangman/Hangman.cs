using System;

namespace HangmanGame
{
    public class Hangman
    {
        public readonly string secretWord;
        public int guessLimit;

        public Hangman(string input)
        {
            this.secretWord = input.ToUpper();
        }
    }
}
