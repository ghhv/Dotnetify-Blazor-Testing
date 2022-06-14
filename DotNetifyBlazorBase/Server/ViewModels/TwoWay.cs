using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class TwoWay : BaseVM
    {
        public string Greetings => $"Hello {Name}";

        private string _name = "World";
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Changed(nameof(Greetings));
            }
        }
    }
}

