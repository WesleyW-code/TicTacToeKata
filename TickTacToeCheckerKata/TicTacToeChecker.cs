using System;

public class TicTacToe
{
    public static void Main()
    {
        var test = new TicTacToe();
        int[,] board = new int[,] { { 1, 1, 0 }, { 2, 2, 2 }, { 1, 2, 0 } };
        var testing = test.IsSolved(board);
        Console.WriteLine(testing);
    }
    public int IsSolved(int[,] board)
    {
        // Gonna go through the rows of the board to check for winners.
        // Default this to 0 for a draw.
        int winner = 0;

        // Default this to 0 for draw and -1 for space left.
        int empty = 0;
        for (int row = 0; row < board.GetLength(0); row++)
        {
            int sumRowAllOnes = 0;
            int sumRowAllTwos = 0;
           
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (board[row,col] == 1)
                {
                    sumRowAllOnes++;
                }
                else if (board[row,col] == 2)
                {
                    sumRowAllTwos += 2;
                }
                // checking if there is spaces available.
                else if (board[row, col] == 0) 
                {
                    empty = -1;
                }
            }
            // Checking if 1 or 2 is winning.
            if (sumRowAllOnes == 3)
            {
                winner = 1; 
            }
            else if (sumRowAllTwos == 6) { winner = 2; }

        }

        // Gonna go through the column of the board to check for winners.
        for (int col = 0; col < board.GetLength(1); col++)
        {
            int sumColAllOnes = 0;
            int sumColAllTwos = 0;

            for (int row = 0; row < board.GetLength(0); row++)
            {
                if (board[row, col] == 1)
                {
                    sumColAllOnes++;
                }
                else if (board[row, col] == 2)
                {
                    sumColAllTwos += 2;
                }
            }
            // Checking if 1 or 2 is winning.
            if (sumColAllOnes == 3)
            {
                winner = 1;
            }
            else if (sumColAllTwos == 6) { winner = 2; }
        }

        // Gonna go through the diagonal options to check for winners.
        // First diagonal position.
        int sumDiagAllOnes = 0;
        int sumDiagAllTwos = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i,i] == 1)
            {
                sumDiagAllOnes++;
            }
            else if (board[i,i] == 2)
            {
                sumDiagAllTwos += 2;
            }  
        }
        if (sumDiagAllOnes == 3)
        {
            winner = 1;
        }
        else if (sumDiagAllTwos == 6) { winner = 2; }
        {

        }

        // Second diagonal position.
        int sumDiagAllOnes2 = 0;
        int sumDiagAllTwos2 = 0;
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 2 - i] == 1)
            {
                sumDiagAllOnes2++;
            }
            else if (board[i,2-i] == 2)
            {
                sumDiagAllTwos2 += 2;
            }
        }
        if (sumDiagAllOnes2 == 3)
        {
            winner = 1;
        }
        else if (sumDiagAllTwos2 == 6) { winner = 2; }

        // if there is no winner and there are open spots it will return -1
        if (winner == 0)
        {
            return empty;
        }
        else
        {
            return winner;
        }
  
    }
}
