using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class ServerUpdate2Way : BaseVM
    {
        //public class Person
        //{
        //    public string FirstName { get; set; }
        //    public string LastName { get; set; }
        //}

        //public string Greetings { get; set; } = "Hello Harry!";
        public void Submit()
        {
            Console.WriteLine($"server save person {FirstName} {LastName}");
            //Greetings = $"Hello {FirstName} {LastName}!";
            Changed(nameof(Greetings));
           
        }

        public string Greetings => $"Hello {FirstName} {LastName}";

        private string _fname = "Cruel";
        public string FirstName
        {
            get => _fname;
            set
            {
                _fname = value;
                Changed(nameof(Greetings));
            }
        }

        private string _lname = "World";
        public string LastName
        {
            get => _lname;
            set
            {
                _lname = value;
                Changed(nameof(Greetings));
            }
        }
    }
}
