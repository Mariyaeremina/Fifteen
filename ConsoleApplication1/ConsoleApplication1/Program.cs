using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game2(1, 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
            var A = new ConsoleGameUI(game);
            A.PrintField();
            A.MakeMove();
            A.MakeMove();
            A.MakeMove();
            A.MakeMove();
            A.MakeMove();
        }
    }
}
