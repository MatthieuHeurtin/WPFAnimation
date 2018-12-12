using heurtin.WpfAnimation.Animation.Calculator.Model;
using heurtin.WpfAnimation.Animation.VanillePricer.ViewModel;
using System;
using System.Windows.Input;

namespace heurtin.WpfAnimation.Animation.VanillePricer.Command
{
    public class RunPricingCommand : ICommand
    {
        private bool _canExecute;
        private Action _action;


        public event EventHandler CanExecuteChanged;

        public RunPricingCommand(Action action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
