using heurtin.WpfAnimation.Animation.Triggers.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace heurtin.WpfAnimation.Animation.Triggers
{
    /// <summary>
    /// Interaction logic for TriggerTesting.xaml
    /// </summary>
    public partial class TriggerTesting : Window, IAnimation
    {

        public static string GetComment()
        {
            return "Triggers Experiment";
        }

        private ICommand _addCommand;

        public ICommand AddCommand
        {
            get { return (_addCommand ?? (_addCommand =  new AddCommandRelay(addElement, true))); }
        }

        private void addElement(string param)
        {
            var elemetToAdd = param.Split(';');
            try
            {
                Elements.Add(
                       new Element()
                       {
                           Name = elemetToAdd[0],
                           Integer = int.Parse(elemetToAdd[1]),
                           Boolean = bool.Parse(elemetToAdd[2])
                       });
            } catch (FormatException ex)
            {
                MessageBox.Show("ERROR ");
            }
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
