using NUnit.Framework;

namespace TicTacToeCheckerTests
{
    public class TicTacToeTests
    {
        // Allows me to test the method in TicTacToeChecker by making a private instance of it which is needed because the class is not static.
        private TicTacToe tictactoe = new TicTacToe();

        [Test]
        public void IsSolved_NoWinnerYet_MovesLeft()
        {
            int[,] board = new int[,] { { 0, 1, 2 }, { 2, 2, 1 }, { 1, 2, 1 } };
            Assert.AreEqual(-1, tictactoe.IsSolved(board));
        }

        [Test]
        public void IsSolved_Draw_NoMovesLeft()
        {
            int[,] board = new int[,] { { 1, 1, 2 }, { 2, 2, 1 }, { 1, 2, 1 } };
            Assert.AreEqual(0, tictactoe.IsSolved(board));
        }

        [Test]
        public void IsSolved_X_wins_Horizontally()
        {
            int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(1,tictactoe.IsSolved(board));
        }

        [Test]
        public void IsSolved_X_wins_Vertically()
        {
            int[,] board = new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
            Assert.AreEqual(1, tictactoe.IsSolved(board));
        }

        [Test]
        public void IsSolved_X_wins_Diagonally_BothWays()
        {
            int[,] board1 = new int[,] { { 1, 0, 0 }, { 0, 1, 2 }, { 0, 0, 1 } };
            int[,] board2 = new int[,] { { 0, 0, 1 }, { 0, 1, 0 }, { 1, 0, 0 } };
            Assert.AreEqual(1, tictactoe.IsSolved(board1));
            Assert.AreEqual(1, tictactoe.IsSolved(board2));
        }

        [Test]
        public void IsSolved_O_wins_Horizontally()
        {
            int[,] board = new int[,] { { 2, 2, 2 }, { 1, 2, 2 }, { 0, 0, 0 } };
            Assert.AreEqual(2, tictactoe.IsSolved(board));
        }

        [Test]
        public void IsSolved_O_wins_Vertically()
        {
            int[,] board = new int[,] { { 0, 2, 0 }, { 0, 2, 0 }, { 0, 2, 0 } };
            Assert.AreEqual(2, tictactoe.IsSolved(board));
        }

        [Test]
        public void IsSolved_O_wins_Diagonally_BothWays()
        {
            int[,] board1 = new int[,] { { 2, 0, 0 }, { 0, 2, 2 }, { 0, 0, 2 } };
            int[,] board2 = new int[,] { { 0, 0, 2 }, { 0, 2, 0 }, { 2, 0, 0 } };
            Assert.AreEqual(2, tictactoe.IsSolved(board1));
            Assert.AreEqual(2, tictactoe.IsSolved(board2));
        }
    }
}