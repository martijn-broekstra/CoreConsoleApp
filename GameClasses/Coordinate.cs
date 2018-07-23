using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public struct Coordinate
    {
        public static Coordinate Up
        {
            get
            {
                return new Coordinate(0, -1);
            }
        }

        public static Coordinate Down
        {
            get
            {
                return new Coordinate(0, 1);
            }
        }

        public static Coordinate Left
        {
            get
            {
                return new Coordinate(-1, 0);
            }
        }

        public static Coordinate Right
        {
            get
            {
                return new Coordinate(1, 0);
            }
        }

        public int X { get; set; }
        public int Y { get; set; }

        public static Coordinate operator +(Coordinate left, Coordinate right)
        {
            return new Coordinate { X = left.X + right.X, Y = left.Y + right.Y };
        }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Wrap(int width, int height)
        {
            X = X >= width ? 0 : X;
            X = X < 0 ? width - 1 : X;

            Y = Y >= height ? 0 : Y;
            Y = Y < 0 ? height - 1 : Y;
        }
    }
}
