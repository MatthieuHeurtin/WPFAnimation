﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace heurtin.WpfAnimation
{
    public class CommandRelay : ICommand
    {
        private Action<string> _action;
        private bool _canExecute;

        public CommandRelay(Action<string> action, bool canExecute)
        {
            _action = action;
            _canExecute = canExecute;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
            _action(parameter as string);
        }
    }
}
