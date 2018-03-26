using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsync
{
    class Vector
    {
        private int start;
        private int end;

        public Vector(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public int Start { get => start; set => start = value; }
        public int End { get => end; set => end = value; }
    }
}
