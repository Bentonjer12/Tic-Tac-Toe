using System;

namespace TickTackToee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            char[,] Board = new char[,] {
                {'-', '-', '-' },
                {'-', '-', '-' },
                {'-', '-', '-' }
            };
            Game(Board);

            
            static void Game(char[,] RunningBoard)
            {
                char player = 'X';
                int turn = 0;
                int x = 0;
                int y = 0;
                while (turn < 9)
                {
                    if (turn % 2 == 0)
                        player = 'X';
                    else
                        player = 'O';
                    turn++;
                    Print(RunningBoard);
                    Console.WriteLine($"\nTurn: {turn}");
                    Console.WriteLine($"It's {player}'s turn\n");
                    Console.Write("Row: ");
                    string choice = Console.ReadLine();
                    int Row = int.Parse(choice);
                    Console.Write("Column: ");
                    string col1 = Console.ReadLine();
                    int col = int.Parse(col1);
                    Picks(choice,col1, ref x, ref y);
                    
                    if (col < 10 && Row<10)
                    {
                        if (RunningBoard[x, y] != 'O' && RunningBoard[x, y] != 'X')
                        {
                            RunningBoard[x, y] = player;
                            Print(RunningBoard);
                        }
                        else
                        {
                            Console.WriteLine("This place is already taken.");
                            turn--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You can only choose between 1-9!");
                        turn--;
                    }
                    if (turn >= 5)
                    {
                        Winner(RunningBoard);
                        if (Winner(RunningBoard) > 0)
                        {
                            Console.WriteLine($"\nPlayer {player} has won the game!\n");
                            Console.WriteLine("Do you want to play again?");
                            Console.WriteLine("Y or N");
                            string answer = Console.ReadLine();
                            string Answer = answer.ToLower();
                            if (Answer == "Y")
                            {
                                Game(RunningBoard);
                            }
                            else
                            {
                                Console.ReadLine();
                            }
                        }
                    }
                }
                Console.WriteLine("\nIt's a DRAW...");  
            }

            

            
            static void Print(char[,] DisplayBoard)
            {
                
                Console.Clear();
                
                Console.WriteLine("Tic Tac Toe\n");
                for (int x = 0; x < DisplayBoard.GetLength(0); x++)
                {
                    for (int y = 0; y < DisplayBoard.GetLength(1); y++)
                    {
                        Console.Write($"{DisplayBoard[x, y]}");
                        if (y != 2)
                            Console.Write(" | ");
                    }
                    if (x != 2)
                        Console.WriteLine("\n—————————");
                }
            }

            
            static void Picks(string row, string col, ref int coordX, ref int coordY)
            {
                if (row == "1"&& col=="1")
                {
                    coordX = 0;
                    coordY = 0;
                }
                if (row == "1" && col== "2")
                {
                    coordX = 0;
                    coordY = 1;
                }
                if (row == "1"&& col=="3")
                {
                    coordX = 0;
                    coordY = 2;
                }
                if (row == "2"&& col=="1")
                {
                    coordX = 1;
                    coordY = 0;
                }
                if (row=="2"&& col=="2")
                {
                    coordX = 1;
                    coordY = 1;
                }
                if (row == "2"&& col=="3")
                {
                    coordX = 1;
                    coordY = 2;
                }
                if (row== "3"&&col=="1")
                {
                    coordX = 2;
                    coordY = 0;
                }
                if (row== "3"&& col=="2")
                {
                    coordX = 2;
                    coordY = 1;
                }
                if (row== "3"&& col=="3")
                {
                    coordX = 2;
                    coordY = 2;
                }
            }

            
            static int Winner(char[,] winnerBoard)
            {
                if (winnerBoard[0, 0] != '-' && winnerBoard[0, 0] == winnerBoard[0, 1] && winnerBoard[0, 0] == winnerBoard[0, 2])
                    return 1;
                if (winnerBoard[0, 0] != '-' && winnerBoard[0, 0] == winnerBoard[1, 0] && winnerBoard[0, 0] == winnerBoard[2, 0])
                    return 1;
                if (winnerBoard[1, 0] != '-' && winnerBoard[1, 0] == winnerBoard[1, 1] && winnerBoard[1, 0] == winnerBoard[1, 2])
                    return 1;
                if (winnerBoard[2, 0] != '-' && winnerBoard[2, 0] == winnerBoard[2, 1] && winnerBoard[2, 0] == winnerBoard[2, 2])
                    return 1;
                if (winnerBoard[0, 1] != '-' && winnerBoard[0, 1] == winnerBoard[1, 1] && winnerBoard[0, 1] == winnerBoard[2, 1])
                    return 1;
                if (winnerBoard[0, 2] != '-' && winnerBoard[0, 0] == winnerBoard[0, 1] && winnerBoard[0, 0] == winnerBoard[0, 2])
                    return 1;
                if (winnerBoard[0, 0] != '-' && winnerBoard[0,0 ] == winnerBoard[1, 1] && winnerBoard[0, 0] == winnerBoard[2, 2])
                    return 1;
                else
                {
                    return 0;
                }


            }

        }
        
    }
}
