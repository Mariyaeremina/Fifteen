using System;
using System.Collections.Generic;
using System.IO;

namespace Fifteen
{
    class Game
    {
        public Field Field;
        public Dictionary<int, Position> Coordinates;
        public int Side
        {
            get
            {
                return Field.SideLength;
            }
        }

        private void check(params int[] numbers)
        {
            var size = Math.Sqrt(numbers.Length);
            var flag = 0;

            if ((size % 1) > 0)
            {
                throw new ArgumentException("Wrong count of number in parameter", "numbers");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    flag++;
                }
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i != j && numbers[i] == numbers[j])
                    {
                        throw new ArgumentException("Repeat number in parameter", "numbers");
                    }
                }
            }

            if (flag == 0)
            {
                throw new ArgumentException("Need empty block in parameter", "numbers");
            }

        }

        private void swap(Position a, Position b)
        {
            Coordinates[Field[a]] = b;
            Coordinates[Field[b]] = a;
            var x = Field[a];
            Field[a] = Field[b];
            Field[b] = x;
        }

        public Game(params int[] numbers)
        {
            check(numbers);
            var size = Math.Sqrt(numbers.Length);
            Field = new Field((int)size);
            Coordinates = new Dictionary<int, Position>();
            WriteData(numbers);
        }

        public void WriteData(params int[] numbers)
        {
            var index = 0;
            for (int i = 0; i < Field.SideLength; i++)
            {
                for (int j = 0; j < Field.SideLength; j++)
                {
                    Field[i, j] = numbers[index];
                    Coordinates[numbers[index]] = new Position();
                    Coordinates[numbers[index]].X = i;
                    Coordinates[numbers[index]].Y = j;
                    index++;
                }
            }
        }

        public Position GetLocation(int value)
        {
            return Coordinates[value];
        }

        public virtual void Shift(int value)
        {
            var temp = new Position();
            var temp0 = new Position();
            temp = GetLocation(value);
            temp0 = GetLocation(0);
            if ((Math.Abs(temp.X - temp0.X) + Math.Abs(temp.Y - temp0.Y)) == 1)
            {
                swap(temp, temp0);
            }

            else
            {
                throw new ArgumentException("The value must be next to the empty block.", "value");
            }
        }

        public static Game ReadFile(string file)
        {
            string line;

            using (StreamReader reader = new StreamReader(file))
            {
                line = reader.ReadToEnd();
            }

            string[] parts = line.Split(';');
            int[] temp = new int[parts.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = int.Parse(parts[i]);
            }

            var MyGame = new Game(temp);
            return MyGame;
        }
    }
}
