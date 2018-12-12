using heurtin.WpfAnimation.Animation.Calculator.Model;
using System;

namespace heurtin.WpfAnimation.Animation.Calculator
{
    public class Pricer : IPricer
    {

        public event EventHandler PricingTerminated;

        public void Price(BSParameter param)
        {

            double d1 = (Math.Log(param.Stock / param.Strike) + param.InterestRate*param.Day + (Math.Pow(param.Vol, 2)*param.Day/2)) / (param.Vol * Math.Sqrt(param.Day));
            double d2 = d1 - (param.Vol * Math.Sqrt(param.Day));


            Console.WriteLine("Matt");
            
            PricingTerminated?.Invoke(this, null);
        }
    }
}


