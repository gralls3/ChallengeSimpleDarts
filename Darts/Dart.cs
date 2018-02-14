using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }
        public bool DoubleRing { get; set; }
        public bool TripleRing { get; set; }

        private Random _random;//creates var to hold random value...
                                    //created next
        public Dart(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0, 21);//this overloaded Next method...
                    //excludes upper bound val thus giving range of 0-20
            int multiplier = _random.Next(1, 101);//rand # from 1-100
            if (multiplier > 95) TripleRing = true;//5% chance of triple
            else if (multiplier > 90) DoubleRing = true;//%10 chance double
        }
    }
}
