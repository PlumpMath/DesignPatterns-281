using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsReview
{
    public sealed class SingletonThreadSafeDoubleCheckLocking
    {
        private static SingletonThreadSafeDoubleCheckLocking instance = null;
        private static readonly object Padlock = new object();

        private SingletonThreadSafeDoubleCheckLocking()
        {

        }

        public static SingletonThreadSafeDoubleCheckLocking Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (Padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonThreadSafeDoubleCheckLocking();
                        }
                    }
                }
                return instance;
            }
        }

}
}
