using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsReview
{
    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get { return instance ?? new Singleton(); }
        }
    }
}
