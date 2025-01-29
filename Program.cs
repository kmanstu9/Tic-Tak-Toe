/*

    TicTacToeTools
    PrintBoard(boardArray, userBox, playerNum) {}
    CheckWinner(boardArray) {}
 
    Welcome the user to the game
    • Create a game board array to store the players’ choices
    • Ask each player in turn for their choice and update the game board array
    • Print the board by calling the method in the supporting class
    • Check for a winner by calling the method in the supporting class, and notify the players
    when a win has occurred and which player won the game


public void PrintBoard(string[] boardArray, int userBox, int playerNum)
public int CheckWinner(string[] boardArray)
 */



using Tik-Tak-Toe;// create TicTacToeTools object
TicTacToeTools t = new TicTacToeTools();

// create board
//int[] board = Enumerable.Range(1, 9).ToArray();


string choice = "";
string player1 = "X";
string player2 = "O";
int gameStatus = 0;
int turn = 2;
string activePlayer = "";
int numericChoice = 0;
string[] board = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("Would you like to be X or O");

Console.WriteLine($"Player 1 is {player1} and Player 2 is {player2}");


// print board
do
{
    t.PrintBoard(board);

    if (turn %2 == 0)
    {
        Console.WriteLine("Player 1, choose your box (1-9):");
        activePlayer = player1;
    }
    else
    {
        Console.WriteLine("Player 2, choose your box (1-9):");
        activePlayer = player2;
    }

    

    do
    { 
        choice = Console.ReadLine();

    } while (!int.TryParse(choice, out numericChoice) || numericChoice < 1 || numericChoice > 9 || board[numericChoice - 1] != numericChoice);

    numericChoice = int.Parse(choice) - 1;
    board[numericChoice] = activePlayer;


    // change player's turn
    turn++;

    // check for winner
    gameStatus = t.CheckWinner(board);

} while (gameStatus == 0);

Console.WriteLine($"Player {gameStatus} wins!");



















