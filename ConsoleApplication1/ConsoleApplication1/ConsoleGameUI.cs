using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class ConsoleGameUI
    {
        public IPlayable interfaceGame;

        public ConsoleGameUI (IPlayable game)
        {
            interfaceGame = game;
            interfaceGame.Randomize();
        }

        public void PrintField ()
        {
            for (int i = 0; i < interfaceGame.Side; i++)
            {
                for (int j = 0; j < interfaceGame.Side; j++)
                {
                    Console.Write(interfaceGame[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }

        public void MakeMove()
        {
            int value = Convert.ToInt32(Console.ReadLine());

            try
            {
                interfaceGame.Shift(value);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Вы ввела неверное значение. Попробуйте снова.");
                MakeMove();
            }
            
            Console.Clear();
            PrintField();
        }

    }
}
