using heurtin.WpfAnimation.Animation.VanillePricer.Calculator.Model;
using NUnit.Framework;
namespace heurtin.WpfAnimation.Animation.VanillePricer.Calculator
{
    //Test classes should be in another project to no end in production
    [TestFixture]
    public class PricerTest
    {
        [TestCase]
        public void TestPrice()
        {
            IPricer model = new Pricer();
            var bsParam = new BSParameter()
            {
                Strike = 65,
                Stock = 60,
                Day = 0.25,
                Vol = 0.3,
                InterestRate = 0.08,
                OptionType = OptionTypeEnum.CallOption
            };

            double price = model.Price(bsParam);
            Assert.AreEqual(2.1333718619310424d, price);
        }
    }
}
