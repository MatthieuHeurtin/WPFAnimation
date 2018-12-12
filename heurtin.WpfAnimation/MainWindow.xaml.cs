using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Reflection;
using System.ComponentModel;
using heurtin.WpfAnimation.Model;
using heurtin.WpfAnimation;

namespace WpfAnimation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICommand _command;

        public ICommand MyCommand
        {
            get
            {
                return (_command ?? (_command = new CommandRelay(SwitchAnimation, true)));
            }
        }

        public ObservableCollection<Element> MyList { get; set; }

        IList<Window> _openedWindow = new List<Window>();

        private Assembly _myAssembly;

        public MainWindow()
        {
            InitializeComponent();

            Closing += OnWindowClosing;

            DataContext = this;

            MyList = new ObservableCollection<Element>();

            _myAssembly = Assembly.LoadFrom(Assembly.GetEntryAssembly().Location);

            foreach (Type type in _myAssembly.GetTypes())
            {
                if (type.GetInterfaces().Where(x => x.Name.Equals("IAnimation")).Any())
                {
                    Element elt = new Element();
                    elt.AnimationName = type.Name;
                    elt.Comment = type.GetMethod("GetComment").Invoke(null, null) as string;
                    MyList.Add(elt);
                }
            }
        }



        private void OnWindowClosing(object sender, CancelEventArgs e)
        {
            if (_openedWindow.Count != 0) { _openedWindow.First().Close(); _openedWindow.Clear(); }
        }

        private void SwitchAnimation(object param)
        {
            string animationName = param as string;

            var animationType = _myAssembly.GetTypes().Where(x => x.Name.Equals(animationName)).First();
                       
            var myInst = Activator.CreateInstance(animationType) as Window;

            if (_openedWindow.Count != 0) { _openedWindow.First().Close(); _openedWindow.Clear(); }

            myInst.Show();

            _openedWindow.Add(myInst);
        }
    }
}

