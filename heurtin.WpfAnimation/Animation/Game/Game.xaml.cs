using heurtin.WpfAnimation.Animation.Game.GraphicElement;
using heurtin.WpfAnimation.Animation.Game.Map;
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
            return "Is it a game";
        }

        private const int SIZE = 6;

        public Game()
        {
            InitializeComponent();

            DataContext = this;

            BuildMap(new BeginMap());







        }

       private void BuildMap(IMap map)
        {
            for (int i = 0; i < SIZE; i++)
            {
                RowDefinition row = new RowDefinition();
                GameArea.RowDefinitions.Add(row);
            }

            for (int i = 0; i < SIZE; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                GameArea.ColumnDefinitions.Add(col);
            }


            for (int i = 0; i < map.Columns.Length; i++)
            {
                for (int j = 0; j < map.Rows.Length; j++)
                {
                    DesertCase f = new DesertCase();
                    Grid.SetRow(f, i);
                    Grid.SetColumn(f, j);
                    GameArea.Children.Add(f);
                }
            }

        }

    }
}
