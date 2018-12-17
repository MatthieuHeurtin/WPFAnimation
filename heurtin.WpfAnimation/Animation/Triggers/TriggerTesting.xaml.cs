using heurtin.WpfAnimation.Animation.Triggers.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace heurtin.WpfAnimation.Animation.Triggers
{
    /// <summary>
    /// Interaction logic for TriggerTesting.xaml
    /// </summary>
    public partial class TriggerTesting : Window, IAnimation, INotifyPropertyChanged
    {

        public static string GetComment()
        {
            return "Triggers Experiment";
        }

        private ICommand _addCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public ICommand AddCommand
        {
            get { return (_addCommand ?? (_addCommand =  new AddCommandRelay(addElement, true))); }
        }

        public bool IsAdded { get; set; }


        /*really ugly method, but enough for testing a basic datatrigger binded to the code behind*/
        private void addElement(string param)
        {
            IsAdded = true;
            OnPropertyChanged("IsAdded");

            Task t = new Task(() =>
            {
                var elemetToAdd = param.Split(';');
                try
                {
                    Thread.Sleep(5000);
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        Elements.Add(
                           new Element()
                           {
                               Name = elemetToAdd[0],
                               Integer = int.Parse(elemetToAdd[1]),
                               Boolean = bool.Parse(elemetToAdd[2])
                           });
                    }));
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("ERROR ");
                }
                finally
                {
                    Application.Current.Dispatcher.Invoke(new Action(() =>
                    {
                        IsAdded = false;
                        OnPropertyChanged("IsAdded");
                    }));
                }

            });

            t.Start();


        }

        public ObservableCollection<Element> Elements { get; set; }

        public TriggerTesting()
        {
            InitializeComponent();

            DataContext = this;

            Elements = new ObservableCollection<Element>
            {
                new Element()
                {
                    Name = "Matt",
                    Integer = 1990,
                    Boolean = true
                },
                new Element()
                {
                    Name = "C#",
                    Integer = 2002,
                    Boolean = true
                }
            };
        }
    }
}
