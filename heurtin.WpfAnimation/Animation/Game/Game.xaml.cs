using heurtin.WpfAnimation.Animation.Game.GraphicElement;
using heurtin.WpfAnimation.Animation.Game.Map;
using heurtin.WpfAnimation.Animation.Game.Map.Maps;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace heurtin.WpfAnimation.Animation.Game
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window, IAnimation
    {
        public static string GetComment()
        {
            return "Is it a game ?";
        }

        public Game()
        {
            InitializeComponent();

            DataContext = this;

            BuildMap(new StartingMap());
        }

       private void BuildMap(IMap map)
        {
            for (int i = 0; i < map.Height; i++)
            {
                RowDefinition row = new RowDefinition();
                GameArea.RowDefinitions.Add(row);
            }

            for (int i = 0; i < map.Width; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                GameArea.ColumnDefinitions.Add(col);
            }


            for (int i = 0; i < map.Height; i++)
            {
                for (int j = 0; j < map.Width; j++)
                {

                    CaseTypes caseType = map.Cases[i, j];

                    ICase caseInst = CaseFactory.GetCaseFromType(caseType);
                    Grid.SetRow(caseInst as UserControl, i);
                    Grid.SetColumn(caseInst as UserControl, j);
                    GameArea.Children.Add(caseInst as UserControl);
                }
            }
        }

    }
}
