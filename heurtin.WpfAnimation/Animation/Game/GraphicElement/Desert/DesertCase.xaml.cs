using System.Windows.Controls;

namespace heurtin.WpfAnimation.Animation.Game.GraphicElement.Desert
{
    /// <summary>
    /// Interaction logic for DesertCase.xaml
    /// </summary>
    public partial class DesertCase : UserControl,ICase
    {

        public CaseTypes Type
        {
            get { return CaseTypes.DESERT; }
        }

        public DesertCase()
        {
            InitializeComponent();
        }
    }
}
