using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4Assignment
{

    internal class Board
    {
        //constructor
        public Board() { }


        public static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    if (j < 2) Console.Write(" | ");
                }

                Console.WriteLine();
                if (i < 2) Console.WriteLine("---------");
            }
        }


        public string ReturnResult(char[,] someBoard, string player)
        {
            string winnerResult = "";

            //some code here
            if (someBoard[0,0] == someBoard[0, 1] && someBoard[0,0] == someBoard[0,2])
            {
                winnerResult = player;
            } else if (someBoard[0, 0] == someBoard[1, 0] && someBoard[0, 0] == someBoard[2, 0])
            {
                winnerResult = player;
            }


            // Can return either "player 1, player 2, or ''."
            return winnerResult;
           
        }

    }
}
