using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class ServerUpdate : BaseVM
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public string Greetings { get; set; } = "Hello Friend!";
        public void Submit(Person person)
        {
            Console.WriteLine($"server save person {person.FirstName} {person.LastName}");
            Greetings = $"Hello {person.FirstName} {person.LastName}!";
            Changed(nameof(Greetings));
           
        }
    }
}
