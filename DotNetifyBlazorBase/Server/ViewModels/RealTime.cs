using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class RealTime : BaseVM
    {
        private Timer _timer;
        public string Greetings => "Hello World!";
        public DateTime ServerTime => DateTime.Now;

        public RealTime()
        {
            _timer = new Timer(state =>
            {
                Changed(nameof(ServerTime));
                PushUpdates();
            }, null, 0, 1000); // every 1000 ms.
        }
        public override void Dispose() => _timer.Dispose();
    }
}
