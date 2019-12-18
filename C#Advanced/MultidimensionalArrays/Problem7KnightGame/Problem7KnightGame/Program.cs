using System;

namespace Problem7KnightGame
{
    class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] chessBoard = new char[size, size];

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    chessBoard[row, col] = input[col];
                }
            }

            for (int row = 0; row < chessBoard.GetLength(0); row++)
            {
                for (int col = 0; col < chessBoard.GetLength(1); col++)
                {
                    int currentKnights = 0;

                    if (chessBoard[row, col] == 'K')
                    {
                        if (chessBoard[row - 2, col + 1] == 'K')
                        {
                            currentKnights++;
                        }
                    }
                }
            }




        }
    }
}
