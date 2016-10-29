using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace DesignPatternsReview
{
    public class TryModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IFlybehavior>().To<FlyWithWing>();
        }
    }
}
