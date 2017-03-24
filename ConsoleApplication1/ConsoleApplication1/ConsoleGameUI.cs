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

        public ConsoleGameUI (Game game)
        {
            interfaceGame = (IPlayable)game;
            interfaceGame.Randomize();
        }

        public void WriteGameField ()
        {
            var game = (Game2)interfaceGame;
            for (int i = 0; i < game.Side; i++)
            {
                for (int j = 0; j < game.Side; j++)
                {
                    Console.Write(game.Field[i, j]);
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
            WriteGameField();
        }

    }
}
