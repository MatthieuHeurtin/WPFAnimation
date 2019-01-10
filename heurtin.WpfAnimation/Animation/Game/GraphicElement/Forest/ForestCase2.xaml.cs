using System.Windows.Controls;

namespace heurtin.WpfAnimation.Animation.Game.GraphicElement.Forest
{
    /// <summary>
    /// Interaction logic for ForestCase2.xaml
    /// </summary>
    public partial class ForestCase2 : UserControl, ICase
    {
        public CaseTypes Type
        {
            get { return CaseTypes.FOREST; }
        }

        public ForestCase2()
        {
            InitializeComponent();
        }

    }
}
