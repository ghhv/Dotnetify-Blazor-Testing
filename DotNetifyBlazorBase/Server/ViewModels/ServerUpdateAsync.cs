using DotNetify;

namespace DotNetifyBlazorBase.Server.ViewModels
{
    public class ServerUpdateAsync : BaseVM
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public override async Task OnCreatedAsync()
        {
            Greetings = await BuildGreetingsAsync();
        }
        public async Task<string> BuildGreetingsAsync()
        {
            string x = "";
            await Task.Run(() =>
            {
                Task.Delay(100).Wait();
                x = $"Hello FirstName LastName!";
            });
            return x;
        }
        public string Greetings { get; set; } = "Hello Friend!";
        public async Task<Task> Submit(Person person)
        {
            await Task.Run(() =>
            {
                Console.WriteLine($"async server save person {person.FirstName} {person.LastName}");
                Greetings = $"Hello {person.FirstName} {person.LastName}!";
                Changed(nameof(Greetings));
                Task.Delay(100).Wait();
            });
            return Task.CompletedTask;
        }
    }
}
