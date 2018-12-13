using heurtin.WpfAnimation.Animation.VanillePricer.Calculator;
using System;
using System.Threading;
using System.Windows.Input;

namespace heurtin.WpfAnimation.Animation.VanillePricer.Command
{
    public class RunPricingCommand : ICommand
    {
        private bool _canExecute;
        private ICancellableTask _instance;
        private Action _action;
        private CancellationTokenSource _cancelToken;

        public event EventHandler CanExecuteChanged;

        public RunPricingCommand(Action action, bool canExecute, ICancellableTask instance)
        {
            _action = action;
            _canExecute = canExecute;
            _instance = instance;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _instance?.CancellationToken.Cancel(); // cancel the task
            CommandWrapper.ExecuteAction(_action, "runCalcul", _instance?.CancellationToken);
        }
    }
}
