namespace JobInterview
{
    public sealed class SingletonThreadSafe
    {
        private static SingletonThreadSafe instance = null;
        private static readonly object PackLock = new object();

        private SingletonThreadSafe()
        {
            
        }

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock (PackLock)
                {
                    return instance ?? new SingletonThreadSafe();
                }
            }
        }
    }
}
