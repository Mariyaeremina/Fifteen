using System;

namespace Fifteen
{
    class Field
    {
        private int[,] blocks;

        public Field(int size)
        {
            blocks = new int[size, size];
        }

        public int this[Position position]
        {
            get
            {
                return blocks[position.X, position.Y];
            }
            set
            {
                blocks[position.X, position.Y] = value;
            }
        }

        public int this[int x, int y]
        {
            get
            {
                return blocks[x, y];
            }
            set
            {
                blocks[x, y] = value;
            }
        }

        public int SideLength
        {
            get
            {
                return blocks.GetLength(0);
            }
        }
    }
}
