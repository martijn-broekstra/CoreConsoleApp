using DataStructures;
using System;
using System.Text;

namespace CoreConsoleApp
{
    class Program
    {
        public const int _xOffset = 5;
        public const int _yOffset = 5;
        public const int _width = 20;
        public const int _height = 20;

        static void Main(string[] args)
        {
            Console.SetWindowSize(_width + 2 * _xOffset, _height + 2 * _yOffset);
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.Unicode;

            var color = ConsoleColor.Cyan;
            var grid = new Grid(_width, _height);


            var position = new Coordinate(0, 0);

            while (true)
            {
                DrawRectangle(_xOffset - 1, _yOffset - 1, _width, _height, color);
                DrawGrid(grid);
                DrawChar(position.X, position.Y, 'ȯ', color);

                var key = Console.ReadKey(true);
                Coordinate? direction = null;
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = Coordinate.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Coordinate.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = Coordinate.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Coordinate.Right;
                        break;
                }


                if (direction.HasValue && grid.CanMove(position, direction.Value))
                {
                    grid.Move(position, direction.Value);
                    position += direction.Value;
                }

                position.Wrap(_width, _height);
            }
        }

        public static void DrawGrid(Grid grid)
        {
            for(int i = 0; i < grid.Width; i++)
            {
                for(int j = 0; j < grid.Height; j++)
                {
                    DrawChar(i, j, grid[i, j].Character, grid[i, j].Color);
                }
            }
        }

        public static void DrawChar(int x, int y, char character, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.CursorTop = y + _yOffset;
            Console.CursorLeft = x + _xOffset;

            Console.Write(character);
            Console.ResetColor();
        }
        public static void DrawRectangle(int x, int y, int width, int height, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Console.CursorTop = y;
            Console.CursorLeft = x;

            string line = "╔";
            for (int i = 0; i < width; i++)
            {
                line += "═";
            }
            line += "╗";

            Console.Write(line);

            for (int i = 0; i < height; i++)
            {
                Console.CursorTop = y + i + 1;
                Console.CursorLeft = x;

                Console.Write("║");
                Console.CursorLeft = x + 1 + width;
                Console.Write("║");
            }
            Console.CursorTop = y + height + 1;
            Console.CursorLeft = x;

            line = "╚";
            for (int i = 0; i < width; i++)
                line += "═";

            line += "╝";
            Console.Write(line);

            Console.ResetColor();
        }

    }
}
