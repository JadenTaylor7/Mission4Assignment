namespace Mission4Assignment
{

    internal class Board
    {
        //constructor
        public Board() { }


        //Builds and prints out the tic tac toe board
        public void PrintBoard(char[,] board)
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


        //Let's the user know if there was a winner or not
        public char ReturnResult(char[,] someBoard)
        {
            char winnerResult = 'C';

            // Assuming someBoard is a 2D char array and player is the current player (either 'X' or 'O')
            //Horizontals
            if (someBoard[0, 0] == someBoard[0, 1] && someBoard[0, 0] == someBoard[0, 2])
            {
                winnerResult = someBoard[0, 0];
            }
            else if (someBoard[1, 0] == someBoard[1, 1] && someBoard[1, 0] == someBoard[1, 2])
            {
                winnerResult = someBoard[1, 0];
            }
            else if (someBoard[2, 0] == someBoard[2, 1] && someBoard[2, 0] == someBoard[2, 2])
            {
                winnerResult = someBoard[2, 0];
            }
            //Verticals
            else if (someBoard[0, 0] == someBoard[1, 0] && someBoard[0, 0] == someBoard[2, 0])
            {
                winnerResult = someBoard[0, 0];
            }
            else if (someBoard[0, 1] == someBoard[1, 1] && someBoard[0, 1] == someBoard[2, 1])
            {
                winnerResult = someBoard[0, 1];
            }
            else if (someBoard[0, 2] == someBoard[1, 2] && someBoard[0, 2] == someBoard[2, 2])
            {
                winnerResult = someBoard[0, 2];
            }
            // Check diagonals
            else if (someBoard[0, 0] == someBoard[1, 1] && someBoard[0, 0] == someBoard[2, 2])
            {
                winnerResult = someBoard[0, 0];
            }
            else if (someBoard[0, 2] == someBoard[1, 1] && someBoard[0, 2] == someBoard[2, 0])
            {
                winnerResult = someBoard[0, 2];
            }
            else
            {
                winnerResult = 'C';
            }


            // Can return either "X, O, or C (for continue)"
            return winnerResult;
        }

    }
}
