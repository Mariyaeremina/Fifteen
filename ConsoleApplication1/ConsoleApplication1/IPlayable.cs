using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fifteen
{
    interface IPlayable
    {
        int Side { get; }
        bool IsFinished { get; }
        void Randomize ();
        void Shift (int value);
        int this[int x, int y] { get; set; }
    }
}
