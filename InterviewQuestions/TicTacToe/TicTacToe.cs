using InterviewQuestions.TicTacToe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewQuestions.AdvancedTicTacToe
{
    public class TicTacToe : ITicTacToe
    {
        private string[,] gameBoard;
        private readonly int n;
        private int winner;
        /// <summary>
        /// Created a Tic Tac Tow game board
        /// </summary>
        /// <param name="n">nxn dimension for the game board</param>
        public TicTacToe(int n)
        {
            this.n = n;
            gameBoard = new string[n, n];
            winner = 0;
        }

        /// <summary>
        /// Place a piece on the game board
        /// </summary>
        /// <param name="row">row to place a piece</param>
        /// <param name="col">column to place a piece</param>
        /// <param name="player">the player (1 or 2) the piece is for</param>
        /// <returns>0 = no winner, 1 = player 1 won, 2 = player 2 won</returns>
        public int PlacePiece(int row, int col, int player)
        {
            if (winner != 0)
            {
                return winner;
            }

            gameBoard[row, col] = player.ToString();
            winner = CheckForWinner(row, col, player);


            return winner;
        }

        private int CheckForWinner(int row, int column, int player)
        {
            if (CheckRowForWinner(row, player) != 0)
            {
                return player;
            }

            if (CheckColumnForWinner(column, player) != 0)
            {
                return player;
            }

            if (CheckDiagnoalForWinner(column, row, player) != 0)
            {
                return player;
            }

            return 0;
        }

        private int CheckRowForWinner(int row, int player)
        {
            for (var i = 0; i < n; i++)
            {
                if (gameBoard[row, i] != player.ToString())
                {
                    return 0;
                }
            }

            return player;
        }

        private int CheckColumnForWinner(int column, int player)
        {
            for (var i = 0; i < n; i++)
            {
                if (gameBoard[i, column] != player.ToString())
                {
                    return 0;
                }
            }

            return player;
        }

        private int CheckDiagnoalForWinner(int column, int row, int player)
        {
            if (column != row && column + row != n - 1)
            {
                return 0;
            }

            if (CheckForwardDiagnolForWinner(player) != 0)
            {
                return player;
            }

            if (CheckBackDiagnolForWinner(player) != 0)
            {
                return player;
            }

            return 0;
        }

        private int CheckForwardDiagnolForWinner(int player)
        {
            for (var i = 0; i < n; i++)
            {
                if (gameBoard[i, i] != player.ToString())
                {
                    return 0;
                }
            }

            return player;
        }

        private int CheckBackDiagnolForWinner(int player)
        {
            for (var i = 0; i < n; i++)
            {
                if (gameBoard[i, n - 1 - i] != player.ToString())
                {
                    return 0;
                }
            }

            return player;
        }
    }
}
