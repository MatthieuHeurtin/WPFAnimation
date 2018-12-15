using heurtin.WpfAnimation.Animation.VanillePricer.Calculator;
using heurtin.WpfAnimation.Animation.VanillePricer.Calculator.Model;
using heurtin.WpfAnimation.Animation.VanillePricer.Command;
using heurtin.WpfAnimation.Animation.VanillePricer.Injector;
using heurtin.WpfAnimation.Animation.VanillePricer.ViewModel;
using Ninject;
using System;
using System.Windows;
using System.Windows.Input;

namespace heurtin.WpfAnimation.Animation.VanillePricer
{
    /// <summary>
    /// Interaction logic for VanillePricerBS.xaml
    /// </summary>
    public partial class VanillePricerBS : Window, IAnimation
    {

        #region command
        private ICommand _runPricing;

        public ICommand RunPricing
        {
            get
            {
                return (_runPricing ?? (_runPricing = new RunPricingCommand(ConvertParamAndPrice, true)));
            }
        }

        private void ConvertParamAndPrice()
        {
            // i don't want to pass the view Model to the code behind
            var bsParam =  new BSParameter()
            {
                Strike = Param.Strike,
                Stock = Param.Stock,
                Day = Param.Day,
                Vol = Param.Vol,
                InterestRate = Param.InterestRate,
                OptionType = OptionTypeEnum.CallOption
            };

            _pricer.Price(bsParam);
        }
        #endregion

        public static string GetComment()
        {
            return "A Call/Put Pricer using the Black Shole formula";
        }

        public ParameterViewModel Param { get; set; }

        private IPricer _pricer;

        public VanillePricerBS()
        {

            IKernel kernel = new StandardKernel(new InjectionMapping());

            InitializeComponent();
            DataContext = this;

            Param = new ParameterViewModel();


            _pricer = kernel.Get<IPricer>();
            _pricer.PricingTerminated += Draw;
        }

        private void Draw(object sender, EventArgs e)
        {
            MessageBox.Show("Matt");
        }
    }
}
