using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobInterview
{
    public sealed class  SingletonThreadSafeDoubleCheckLocking
    {
        private static SingletonThreadSafeDoubleCheckLocking instance = null;
        private static readonly object Padlock = new object();


    }
}
