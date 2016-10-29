namespace DesignPatternsReview
{
    public sealed class SingletonThreadSafeWithoutUsingLocks
    {
        private static SingletonThreadSafeWithoutUsingLocks instace = null;

        static SingletonThreadSafeWithoutUsingLocks() 
        {
            /*static constructors in C# are specified to execute only when an instance of the class is 
             * created or a static member is referenced, and to execute only once per AppDomain. */
        }

        private SingletonThreadSafeWithoutUsingLocks()
        {
            
        }

        public static SingletonThreadSafeWithoutUsingLocks Instance
        {
            get { return instace; }
        }
    }
}
