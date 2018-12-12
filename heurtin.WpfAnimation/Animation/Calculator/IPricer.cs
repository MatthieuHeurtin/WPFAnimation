using heurtin.WpfAnimation.Animation.Calculator.Model;
using System;

namespace heurtin.WpfAnimation.Animation.Calculator
{
    public interface IPricer
    {
        void Price(BSParameter param);
        event EventHandler PricingTerminated;
    }
}