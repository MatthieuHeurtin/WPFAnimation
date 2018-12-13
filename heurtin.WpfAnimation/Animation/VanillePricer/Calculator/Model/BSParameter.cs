namespace heurtin.WpfAnimation.Animation.VanillePricer.Calculator.Model
{
    public class BSParameter
    {
        public double Strike { get; set; }
        public double Stock { get; set; }
        public double Day { get; set; }
        public double Vol { get; set; }
        public double InterestRate { get; set; }
        public OptionTypeEnum OptionType { get; set; }
    }

    public enum OptionTypeEnum
    {
        CallOption,
        PutOption
    }
}
