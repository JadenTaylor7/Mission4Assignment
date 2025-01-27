// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using Mission4Assignment;

Board bd = new Board();

Console.WriteLine("Welcome to Tic-Tac-Toe!");
//  the game board (3x3 grid)
char[,] board = {
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

// These are variables to keep track of the game
char testWin = 'C';
int turns = 0;
char currentPlayer = 'X';
List<int> usedSpots = new List<int>();

// Main game loop (I did not finish this all the way)
while (testWin == 'C' && turns <= 9)
{
    Console.Clear();
    Console.WriteLine("");
    bd.PrintBoard(board);
    // Ask the current player for their choice
    Console.WriteLine($"Player {currentPlayer}, choose a position: ");
    string input = Console.ReadLine();
    
    if (int.TryParse(input, out int position) && position >= 1 && position <= 9 && !usedSpots.Contains(position))
    {
        if (position >= 1 && position <= 3)
            board[0, position - 1] = currentPlayer;
        else if (position >= 4 && position <= 6)
            board[1, position - 3 - 1] = currentPlayer;
        else if (position >= 7 && position <= 9)
            board[2, position - 6 - 1] = currentPlayer;
        
        usedSpots.Add(position);
        turns++;

        if (currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
        
        
        testWin = bd.ReturnResult(board);
        
    } else
    {
        Console.WriteLine("Invalid position! Try again.");
    }
}

if (testWin == 'X')
{
    Console.WriteLine("Player X won!");
}
else if (testWin == 'O')
{
    Console.WriteLine("Player O won!");
} else if (testWin == 'C' && turns >= 9)
{
    Console.WriteLine("Its a draw!");
}
    

