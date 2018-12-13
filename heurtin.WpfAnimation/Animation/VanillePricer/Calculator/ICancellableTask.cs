using System.Threading;

namespace heurtin.WpfAnimation.Animation.VanillePricer.Calculator
{
    public interface ICancellableTask
    {
        CancellationTokenSource CancellationToken { get;  }
    }
}