using System.Threading.Tasks;
using TfLConsoleApp1.Class;
using TfLConsoleApp1.Controller;

namespace TfLConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            Terminal terminal = DependencyModule.MakeTerminal();

            terminal.DisplayInstructions();
            await terminal.Standby();
        }
    }
}
