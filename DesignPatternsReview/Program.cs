using System;
using Ninject;

namespace DesignPatternsReview
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
            Ninject.IKernel kernel = new StandardKernel();
            kernel.Bind<IFlybehavior>().To<FlyWithWing>();
            var instance = kernel.Get<Duck>();
            instance.PerformanceFly();*/
            
            Duck duck = new Duck(new FlyWithWing());
            duck.PerformanceFly();
            Console.ReadLine();
        }
    }
}
