namespace heurtin.WpfAnimation.Animation.Game.Map
{
    public interface IMap
    {
        CaseTypes[] Rows { get; }
        CaseTypes[] Columns { get; }
    }
}