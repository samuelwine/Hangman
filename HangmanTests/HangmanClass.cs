using HangmanGame;
using Xunit;

namespace HangmanTests
{
    public class HangmanClass
    {
        [Fact]
        public void StoresSecretWordAsAllCaps()
        {
            var game = new Hangman("hello");
            Assert.Equal("HELLO", game.secretWord);
        }

        [Fact]
        public void StoresGuessLimitOnCreation()
        {
            var game = new Hangman("hello");
            Assert.True(game.guessLimit > 0);

        }
    }
}
