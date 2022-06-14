using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class SmartEnumVM : BaseVM
    {
        public string Greetings => "Hello Harry World!";
        public class DropDownItem
        {
            public int Id { get; set; }
            public string Text { get; set; }
        }

        public string DropDownCaption => "Select an item ...";

        public List<DropDownItem> DropDownOptions
        {
            get => new List<DropDownItem>
            {
                new DropDownItem { Id = 1, Text = "Object One" },
                new DropDownItem { Id = 2, Text = "Object Two" },
                new DropDownItem { Id = 3, Text = "Object Three" },
                new DropDownItem { Id = 4, Text = "Object Four" }
            };
        }

        public int DropDownValue
        {
            get => Get<int>();
            set
            {
                Set(value);
                Changed(() => DropDownResult);
            }
        }

        public string DropDownResult => DropDownValue > 0 ? $"You selected: {DropDownOptions.First(i => i.Id == DropDownValue).Text}" : null;

    }
}
