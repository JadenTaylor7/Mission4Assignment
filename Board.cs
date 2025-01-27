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


        static void PrintBoard(char[,] board)
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


        public string ReturnResult(char[,] someBoard)
        {
            string winnerResult = "";

            //some code here


            // Can return either "player 1, player 2, or ''."
            return winnerResult;
           
        }

    }
}
