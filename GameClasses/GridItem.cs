using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    [Flags]
    public enum Properties
    {
        Moveable = 1,
        Passable = 2,
    }

    public class GridItem
    {
        public static GridItem Empty
        {
            get
            {
                return new GridItem('\0', ConsoleColor.Black);
            }
        }
        public char Character { get; set; }
        public ConsoleColor Color { get; set; }
        public Properties Properties { get; set; }

        public bool IsEmpty
        {
            get
            {
                return Character == '\0';
            }
        }

        public bool IsBlocking
        {
            get
            {
                return !Properties.HasFlag(Properties.Moveable);
            }
        }


        public GridItem(char character, ConsoleColor color)
        {
            this.Character = character;
            this.Color = color;
        }
    }
}
