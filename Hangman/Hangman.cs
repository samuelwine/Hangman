using System;

namespace HangmanGame
{
    public class Hangman
    {
        public string secretWord;
        public int guessLimit = 10;

        public Hangman(string input)
        {
            secretWord = input.ToUpper();
        }
    }
}
