using heurtin.WpfAnimation.Animation.VanillePricer.Calculator.Model;
using System;

namespace heurtin.WpfAnimation.Animation.VanillePricer.Calculator
{
    public interface IPricer : ICancellableTask
    {
        double Price(BSParameter param);
        event EventHandler PricingTerminated;
    }
}