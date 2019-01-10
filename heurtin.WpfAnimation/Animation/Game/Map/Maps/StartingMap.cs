using heurtin.WpfAnimation.Animation.Game.GraphicElement;

namespace heurtin.WpfAnimation.Animation.Game.Map.Maps
{
    public class StartingMap : IMap
    {
        public CaseTypes[,] Cases
        {
            get { return _cases; }
        }

        private readonly CaseTypes[,] _cases;

        public int Width
        {
            get { return _width; }
        }

        private readonly int _width;

        public int Height
        {
            get { return _height; }
        }

        private readonly int _height;


        public StartingMap()
        {
            _height = 6;
            _width = 6;
            _cases = new CaseTypes[_width, _height];
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    _cases[i, j] = CaseTypes.FOREST;
                }

            }

            _cases[3, 5] = CaseTypes.DESERT;
        }
    }
}
