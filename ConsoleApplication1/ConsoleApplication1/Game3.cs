using System;
using System.Collections.Generic;

namespace Fifteen
{
    class Game3 : Game2
    {
       

        public Game3(params int[] numbers) : base(numbers)
        {
            shiftHistory = new List<int>();
            cancelHistory = new List<int>();
        }

        public override void Shift(int value)
        {
            base.Shift(value);
            shiftHistory.Add(value);
            cancelHistory.Clear();
        }

        public override void Randomize()
        {
            base.Randomize();
            shiftHistory.Clear();
            cancelHistory.Clear();
        }

        private void changeMove(List<int> changedList, List<int> historyList, int value)
        {
            if (value <= changedList.Count && value > 0)
            {
                if (changedList.Count > 0)
                {
                    for (int i = 0; i < value; i++)
                    {
                        var index = changedList.Count - 1;
                        var temp = changedList[index];
                        base.Shift(temp);
                        historyList.Add(temp);
                        changedList.RemoveAt(index);
                    }
                }

                else
                {
                    throw new ArgumentException("The History is empty.");
                }
            }

            else
            {
                throw new ArgumentException("The number is greater than the number of moves.");
            }
        }

        public void Undo(int value)
        {
            changeMove(shiftHistory, cancelHistory, value);
        }

        public void Redo(int value)
        {
            changeMove(cancelHistory, shiftHistory, value);
        }
    }
}
