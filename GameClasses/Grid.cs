using System;

namespace DataStructures
{
    public class Grid
    {
        private GridItem[,] _grid;

        public int Width
        {
            get
            {
                return _grid.GetLength(0);
            }
        }
        public int Height
        {
            get
            {
                return _grid.GetLength(1);
            }
        }

        public GridItem this[int x, int y]
        {
            get
            {
                return _grid[x, y] ?? GridItem.Empty;
            }
            private set
            {
                _grid[x, y] = value;
            }
        }

        public Grid(int width, int height)
        {
            _grid = new GridItem[width, height];

            // Test
            _grid[7, 15] = new GridItem('X', ConsoleColor.Red);
            _grid[7, 14] = new GridItem('X', ConsoleColor.Red);
            _grid[7, 13] = new GridItem('X', ConsoleColor.Red);
            _grid[7, 12] = new GridItem('X', ConsoleColor.Red);
            _grid[7, 11] = new GridItem('X', ConsoleColor.Red);
            _grid[7, 10] = new GridItem('X', ConsoleColor.Red);
            _grid[8, 15] = new GridItem('2', ConsoleColor.Cyan);
            _grid[9, 15] = new GridItem('3', ConsoleColor.Cyan);
            _grid[10, 15] = new GridItem('+', ConsoleColor.Cyan);
            _grid[11, 15] = new GridItem('5', ConsoleColor.Cyan);
            _grid[11, 14] = new GridItem('6', ConsoleColor.Cyan);
            _grid[11, 13] = new GridItem('7', ConsoleColor.Cyan);
            _grid[11, 12] = new GridItem('8', ConsoleColor.Cyan);
        }

        public bool CanMove(Coordinate coordinate, Coordinate direction)
        {
            var nextCoordinate = coordinate + direction;
            nextCoordinate.Wrap(this.Width, this.Height);

            if (this[nextCoordinate.X, nextCoordinate.Y].IsEmpty)
            {
                return true;
            }
            else if (this[nextCoordinate.X, nextCoordinate.Y].IsBlocking)
            {
                return false;
            }
            else
            {
                return CanMove(nextCoordinate, direction);
            }
        }

        private void ExecuteMove(Coordinate coordinate, Coordinate direction)
        {
            var nextCoordinate = coordinate + direction;
            nextCoordinate.Wrap(this.Width, this.Height);

            if (!this[nextCoordinate.X, nextCoordinate.Y].IsEmpty)
            {
                ExecuteMove(nextCoordinate, direction);
            }

            this[nextCoordinate.X, nextCoordinate.Y] = this[coordinate.X, coordinate.Y];
            this[coordinate.X, coordinate.Y] = GridItem.Empty;
        }

        public void Move(Coordinate coordinate, Coordinate direction)
        {
            if (CanMove(coordinate, direction))
            {
                ExecuteMove(coordinate, direction);
            }
        }
    }
}
