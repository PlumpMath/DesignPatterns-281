using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsReview
{
    public class FlyWithWing : IFlybehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying.");
        }
    }
}
