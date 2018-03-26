using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DemoAsync
{
    public class Vector
    {
        private BigInteger start;
        private BigInteger end;
  

        public Vector(BigInteger start, BigInteger end)
        {
            this.start = start;
            this.end = end;
        }


        public BigInteger Start { get => start; set => start = value; }
        public BigInteger End { get => end; set => end = value; }
    }
}
