using heurtin.WpfAnimation.Animation.Game.GraphicElement;
using heurtin.WpfAnimation.Animation.Game.GraphicElement.Desert;
using heurtin.WpfAnimation.Animation.Game.GraphicElement.Forest;
using System.Linq;
using System.Reflection;

namespace heurtin.WpfAnimation.Animation.Game.Map
{
    public class CaseFactory
    {

        private static Assembly _myAssembly = Assembly.LoadFrom(Assembly.GetEntryAssembly().Location);


        public static ICase GetCaseFromType(CaseTypes caseType)
        {
            switch (caseType)
            {
                case CaseTypes.FOREST:
                    var t = new ForestCase();
                    t.AddImage();
                    return t;
                case CaseTypes.DESERT:
                    return new DesertCase();
                default:
                    throw new System.Exception();
            }
        }
    }
}
