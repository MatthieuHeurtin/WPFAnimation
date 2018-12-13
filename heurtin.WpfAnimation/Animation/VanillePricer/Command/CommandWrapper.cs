using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace heurtin.WpfAnimation.Animation.VanillePricer.Command
{
    public static class CommandWrapper
    {
        private static ConcurrentDictionary<string,Task>  _tasks = new ConcurrentDictionary<string, Task>();

        public static void ExecuteAction(Action action, string actionId, CancellationTokenSource token)
        {
            Task t;
            if (_tasks.TryGetValue(actionId, out t))
            {
               
            }

            Task newTask = new Task(action, token.Token);
            _tasks.TryAdd(actionId, newTask);
            newTask.Start();
        }
    }
}
