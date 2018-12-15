using heurtin.WpfAnimation.Animation.Triggers.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;
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


        public ObservableCollection<Element> Elements { get; set; }

        public TriggerTesting()
        {
            InitializeComponent();

            DataContext = this;

            Elements = new ObservableCollection<Element>
            {
                new Element()
                {
                    Name = "Matt"
                }
            };
        }
    }
}
