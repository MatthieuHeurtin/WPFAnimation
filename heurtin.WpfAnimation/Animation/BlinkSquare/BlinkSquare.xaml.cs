using System.Windows;

namespace heurtin.WpfAnimation.Animation.BlinkSquare
{
    /// <summary>
    /// Interaction logic for BlinkSquare.xaml
    /// </summary>
    public partial class BlinkSquare : Window, IAnimation
    {
        public static string GetComment()
        {
            return "The First Animation, from the example of MSDN";
        }

        public BlinkSquare()
        {
            InitializeComponent();
        }
    }
}
