using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class ServerUpdateSubmit : BaseVM
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public string? Greetings { get; set; } //= "Hello Friend!";
        public override async Task OnCreatedAsync()
        {
            Greetings = await BuildGreetingsAsync();
            Changed(nameof(Greetings));
        }
        public string Id { get; set; } = "";
        public async Task Submit(Person person)
        {
            Console.WriteLine($"server save person {person.FirstName} {person.LastName}");
            Greetings = $"Hello {person.FirstName} {person.LastName}!";
            Id = Guid.NewGuid().ToString();
            Changed(nameof(Greetings));
            Changed(nameof(Id));
            await Task.Delay(1000);
            Console.WriteLine($"server save ID {Id}");
        }

        public async Task<string> BuildGreetingsAsync()
        {
            await Task.Delay(10);
            return "Hello Friend!";
        }
    }
}
