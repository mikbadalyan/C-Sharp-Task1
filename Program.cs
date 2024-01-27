// Creating a chess board. Each empty field is marked as 0.
int rows = 8;
int columns = 8;

int[,] chess_board = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        chess_board[i, j] = 0;
    }
} 
//

//Placing the knight in a random location.
Random random = new Random();

int knight_row = random.Next(0, 7);
int knight_column = random.Next(0, 7);

chess_board[knight_row, knight_column] = 9;
//


// Algorithm to show the knight strokes on the chess board.
for (int i = 1; i < 3; i++)
{
    int j = 3 - i;
    if (knight_row + i <= 7 && knight_column + j <= 7)
    {
        chess_board[knight_row + i, knight_column + j] = 1;
            
    }
    if (knight_row + i <= 7 && knight_column - j >= 0)
    {
        chess_board[knight_row + i, knight_column - j] = 1;
            
    }
    if (knight_row - i >= 0 && knight_column - j >= 0)
    {
        chess_board[knight_row - i, knight_column - j] = 1;
            
    }
    if (knight_row - i >= 0 && knight_column + j <= 7)
    {
        chess_board[knight_row - i, knight_column + j] = 1;
            
    }
        
}
//

//Visualizing the chess board in the console.
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(chess_board[i, j] + " ");
    }
    Console.WriteLine();
}
//