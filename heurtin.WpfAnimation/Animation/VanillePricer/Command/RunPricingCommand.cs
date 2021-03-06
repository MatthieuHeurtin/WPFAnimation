﻿using heurtin.WpfAnimation.Animation.VanillePricer.Calculator;
using System;
using System.Threading;
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
            _canExecute = false;
            _action();
        }
    }
}
