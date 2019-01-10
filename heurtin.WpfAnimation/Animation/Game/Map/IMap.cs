using heurtin.WpfAnimation.Animation.Game.GraphicElement;

namespace heurtin.WpfAnimation.Animation.Game.Map
{
    public interface IMap
    {
        CaseTypes[,] Cases { get; }
        int Height { get; }
        int Width { get; }

    }
}