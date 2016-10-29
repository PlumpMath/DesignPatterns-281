using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsReview
{
    public class Duck 
    {
        readonly IFlybehavior _flybehavior;

        public Duck(IFlybehavior flybehavior)
        {
            _flybehavior = flybehavior;
        }

        public void PerformanceFly()
        {
            _flybehavior.Fly();
        }
    }
}
