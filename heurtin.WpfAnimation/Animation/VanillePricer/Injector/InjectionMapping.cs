using heurtin.WpfAnimation.Animation.VanillePricer.Calculator;
using Ninject.Modules;

namespace heurtin.WpfAnimation.Animation.VanillePricer.Injector
{
    public class InjectionMapping : NinjectModule
    {
        public override void Load()
        {
            Bind<IPricer>().To<Pricer>();

        }
    }
}
