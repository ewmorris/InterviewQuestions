using InterviewQuestions.UniqueEmail;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions.AdvancedTicTacToe;

namespace InterviewUnitTest
{
    [TestClass]
    public class TicTacToeTests
    {
        [TestMethod]
        public void Test3x3Winner1Horizontal ()
        {
            var game = new TicTacToe(3);
            var winner = 0;
            //Player 1 First move
            winner = game.PlacePiece(0, 0, 1);
            Assert.AreEqual(0, winner);
            //Player 2 First Move
            winner =game.PlacePiece(1, 0, 2);            
            Assert.AreEqual(0, winner);
            //Player 1 second move
            winner = game.PlacePiece(0, 1, 1);
            Assert.AreEqual(0, winner);
            //Player 2 secondm move
            winner = game.PlacePiece(1, 1, 2);
            Assert.AreEqual(0, winner);
            //Player 1 third move
            winner = game.PlacePiece(0, 2, 1);
            Assert.AreEqual(1, winner);

        }

        [TestMethod]
        public void Test3x3Winner2Verticle()
        {
            var game = new TicTacToe(3);
            var winner = 0;
            //Player 1 First move
            winner = game.PlacePiece(0, 2, 1);
            Assert.AreEqual(0, winner);
            //Player 2 First Move
            winner = game.PlacePiece(0, 0, 2);
            Assert.AreEqual(0, winner);
            //Player 1 second move
            winner = game.PlacePiece(0, 1, 1);
            Assert.AreEqual(0, winner);
            //Player 2 secondm move
            winner = game.PlacePiece(1, 0, 2);
            Assert.AreEqual(0, winner);
            //Player 1 third move
            winner = game.PlacePiece(1, 1, 1);
            Assert.AreEqual(0, winner);
            //Player 2 third move
            winner = game.PlacePiece(2, 0, 2);
            Assert.AreEqual(2, winner);
        }

        [TestMethod]
        public void Test3x3Winner1BackSlash()
        {
            var game = new TicTacToe(3);
            var winner = 0;

            //Player 1 First move
            winner = game.PlacePiece(0, 0, 1);
            Assert.AreEqual(0, winner);

            //Player 2 First move
            winner = game.PlacePiece(0, 1, 1);
            Assert.AreEqual(0, winner);

            //Player 1 Second move
            winner = game.PlacePiece(1, 1, 1);
            Assert.AreEqual(0, winner);

            //Player 2 First move
            winner = game.PlacePiece(0, 2, 1);
            Assert.AreEqual(0, winner);

            //Player 1 Third move
            winner = game.PlacePiece(2, 2, 1);
            Assert.AreEqual(1, winner);
        }

        [TestMethod]
        public void Test3x3Winner1Slash()
        {
            var game = new TicTacToe(3);
            var winner = 0;

            //Player 1 First move
            winner = game.PlacePiece(2, 0, 1);
            Assert.AreEqual(0, winner);

            //Player 2 First move
            winner = game.PlacePiece(0, 1, 1);
            Assert.AreEqual(0, winner);

            //Player 1 Second move
            winner = game.PlacePiece(1, 1, 1);
            Assert.AreEqual(0, winner);

            //Player 2 First move
            winner = game.PlacePiece(1, 2, 1);
            Assert.AreEqual(0, winner);

            //Player 1 Third move
            winner = game.PlacePiece(0, 2, 1);
            Assert.AreEqual(1, winner);
        }

        [TestMethod]
        public void Test3x3Winner1HorizontalNoExtraMoveAfterWin()
        {
            var game = new TicTacToe(3);
            var winner = 0;
            //Player 1 First move
            winner = game.PlacePiece(0, 0, 1);
            Assert.AreEqual(0, winner);
            //Player 2 First Move
            winner = game.PlacePiece(1, 0, 2);
            Assert.AreEqual(0, winner);
            //Player 1 second move
            winner = game.PlacePiece(0, 1, 1);
            Assert.AreEqual(0, winner);
            //Player 2 secondm move
            winner = game.PlacePiece(1, 1, 2);
            Assert.AreEqual(0, winner);
            //Player 1 third move
            winner = game.PlacePiece(0, 2, 1);
            Assert.AreEqual(1, winner);
            //Player 2 third move
            winner = game.PlacePiece(1, 2, 1);
            Assert.AreEqual(1, winner);
        }

    }
}
