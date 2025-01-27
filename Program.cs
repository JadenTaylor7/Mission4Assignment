// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Tic-Tac-Toe!");
//  the game board (3x3 grid)
char[,] board = {
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};
// These are variables to keep track of the game
bool gameWon = false;
int turns = 0;
char currentPlayer = 'X';
// Main game loop (I did not finish this all the way)
while (!gameWon && turns < 9)
{
    PrintBoard(board);
    // Ask the current player for their choice
    Console.WriteLine($"Player {currentPlayer}, choose a position: ");
    string input = Console.ReadLine();
    if (int.TryParse(input, out int position) && position >= 1 && position <= 9)
    {
    }

}
