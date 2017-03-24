using System;

namespace Fifteen
{
    class Game2 : Game, IPlayable
    {
        public Game2(params int[] numbers) : base(numbers) { }

        public bool IsFinished
        {
            get
            {
                if (Field[Side - 1, Side - 1] == 0)
                {
                    var count = 1;
                    for (int i = 0; i < Side; i++)
                    {
                        for (int j = 0; j < Side; j++)
                        {
                            if (Field[i, j] != count && Field[i, j] != 0)
                            {
                                return false;
                            }
                            count++;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private int[] getRandomSiquence()
        {
            int[] numbers = new int[Side * Side];

            var rand = new Random();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = rand.Next(1, numbers.Length);
                if (i > 0)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            i--;
                            break;
                        }
                    }
                }
            }

            numbers[numbers.Length - 1] = numbers.Length;

            var count = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        count++;
                    }
                }
            }

            if (count % 2 != 0)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == numbers.Length - 1)
                    {
                        numbers[i] = numbers.Length - 2;
                    }
                    else if (numbers[i] == numbers.Length - 2)
                    {
                        numbers[i] = numbers.Length - 1;
                    }
                }
            }
            numbers[numbers.Length - 1] = 0;

            return numbers;
        }

        public virtual void Randomize()
        {
            Coordinates.Clear();
            WriteData(getRandomSiquence());
        }
    }


}
