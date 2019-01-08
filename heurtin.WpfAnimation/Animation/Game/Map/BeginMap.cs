using heurtin.WpfAnimation.Animation.Game.GraphicElement;

namespace heurtin.WpfAnimation.Animation.Game.Map
{
    public class BeginMap : IMap
    {
        public CaseTypes[] Rows
        {
            get { return _rows; }
        }

        private readonly CaseTypes[] _rows;

        public CaseTypes[] Columns
        {
            get { return _columns; }
        }

        private readonly CaseTypes[] _columns;


        public BeginMap()
        {
            _rows = new CaseTypes[6];
            for(int i =0; i < 6;i++)
            {
                _rows[i] = CaseTypes.FOREST;
            }

            _columns = new CaseTypes[6];
            for (int i = 0; i < 6; i++)
            {
                _columns[i] = CaseTypes.FOREST;
            }
        }
    }
}
