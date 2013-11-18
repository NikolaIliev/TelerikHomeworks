namespace FallingRocks
{
    using System;
    using System.Threading;
    class FallingRocksGame
    {
        static RockRow[] rocks = new RockRow[Console.WindowHeight - 1];
        static int score = 0;
        static int playerColumn = Console.WindowWidth / 2;

        static void InitializeRockRows()
        {
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            {
                rocks[i] = new RockRow();
                for (int j = 0; j < 5; j++)
                {
                    rocks[i].row[j] = new Rock();
                }
            }
        }

        static void CleanUpConsole()
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
        }

        static void PrintAtPositionColor(int coordX, int coordY, char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.SetCursorPosition(coordX, coordY);
            Console.Write(symbol);
        }

        static void DrawPlayer()
        {
            PrintAtPositionColor(playerColumn - 1, Console.WindowHeight - 1, '(', ConsoleColor.Red);
            PrintAtPositionColor(playerColumn, Console.WindowHeight - 1, 'O', ConsoleColor.Yellow);
            PrintAtPositionColor(playerColumn + 1, Console.WindowHeight - 1, ')', ConsoleColor.Red);
        }

        static void MovePlayerLeft()
        {
            if (playerColumn > 1)
            {
                playerColumn--;
            }
        }

        static void MovePlayerRight()
        {
            if (playerColumn < Console.WindowWidth - 1)
            {
                playerColumn++;
            }
        }

        static void MoveRocks()
        {
            for (int i = Console.WindowHeight - 2; i > 0; i--)
            {
                int newLength = rocks[i - 1].rowLength;
                rocks[i] = new RockRow(newLength);
                for (int j = 0; j < newLength; j++)
                {
                    rocks[i].row[j] = new Rock(rocks[i - 1].row[j].column, rocks[i - 1].row[j].density, rocks[i - 1].row[j].color, rocks[i - 1].row[j].symbol);
                }
            }
        }

        static void GenerateFirstRow()
        {
            Random generator = new Random();
            int numberOfRocks = generator.Next(1, 6);
            rocks[0] = new RockRow(numberOfRocks);
            for (int i = 0; i < numberOfRocks; i++)
            {
                int column = generator.Next(0, Console.WindowWidth - 3);
                int density = generator.Next(1, 4);
                int colorNum = generator.Next(1, 8);
                int symbolNum = generator.Next(1, 8);
                char symbol = '0';
                ConsoleColor color = ConsoleColor.Black;
                switch (colorNum)
                {
                    case 1: color = ConsoleColor.Blue; break;
                    case 2: color = ConsoleColor.DarkGreen; break;
                    case 3: color = ConsoleColor.DarkGray; break;
                    case 4: color = ConsoleColor.DarkRed; break;
                    case 5: color = ConsoleColor.DarkCyan; break;
                    case 6: color = ConsoleColor.DarkYellow; break;
                    case 7: color = ConsoleColor.DarkMagenta; break;
                    default: Console.WriteLine("Something's wrong..."); break;
                }
                switch (symbolNum)
                {
                    case 1: symbol = '^'; break;
                    case 2: symbol = '@'; break;
                    case 3: symbol = '*'; break;
                    case 4: symbol = '&'; break;
                    case 5: symbol = '+'; break;
                    case 6: symbol = '%'; break;
                    case 7: symbol = '$'; break;
                    default: Console.WriteLine("something's wrong"); break;
                }
                rocks[0].row[i] = new Rock(column, density, color, symbol);
            }
        }

        static void DrawRocks()
        {
            for (int i = 0; i < Console.WindowHeight - 1; i++)
            {
                for (int j = 0; j < rocks[i].rowLength; j++)
                {
                    for (int k = 0; k < rocks[i].row[j].density; k++)
                    {
                        PrintAtPositionColor(rocks[i].row[j].column + k, i + 1, rocks[i].row[j].symbol, rocks[i].row[j].color);
                    }
                }
            }
        }

        static bool CheckCollision()
        {
            for (int i = 0; i < rocks[Console.WindowHeight - 2].rowLength; i++)
            {
                if (playerColumn == rocks[Console.WindowHeight - 2].row[i].column)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main()
        {
            CleanUpConsole();
            InitializeRockRows();
            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    if (input.Key == ConsoleKey.LeftArrow)
                    {
                        MovePlayerLeft();
                    }
                    else if (input.Key == ConsoleKey.RightArrow)
                    {
                        MovePlayerRight();
                    }
                }
                DrawPlayer();
                MoveRocks();
                GenerateFirstRow();
                DrawRocks();
                if (CheckCollision())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                }
                score++;
                Thread.Sleep(150);
            }
            Console.WriteLine("Game over! Your score is: {0}", score);
        }
    }
}
