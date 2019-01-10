using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace heurtin.WpfAnimation.Animation.Game.GraphicElement.Forest
{
    /// <summary>
    /// Interaction logic for ForestCase.xaml
    /// </summary>
    public partial class ForestCase : UserControl, ICase
    {

        public CaseTypes Type
        {
            get { return CaseTypes.FOREST; }
        }


        public ForestCase()
        {
            InitializeComponent();
        }

        public void AddImage()
        {

            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri("pack://application:,,,/Animation/Game/GraphicElement/Ressources/Images/mainCharacter.png");
            b.EndInit();

            Image image = new Image();
            image.Source = b;

            MainGrid.Children.Add(image);
        }

        
    }
}
