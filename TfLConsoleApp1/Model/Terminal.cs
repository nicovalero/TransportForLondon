using System;
using System.Threading.Tasks;
using TfLConsoleApp1.Controller;

namespace TfLConsoleApp1.Class
{
    public class Terminal
    {
        private const string EXIT = "exit";
        private RequestController _controller;

        public Terminal(RequestController controller)
        {
            _controller = controller;
        }

        public async Task Standby()
        {
            var command = "";

            while (command.ToString().ToLower() != EXIT)
            {
                command = Console.ReadLine();

                if (command.ToLower() != EXIT)
                {
                    Road road = await _controller.GetRoadInformation(command);

                    if (road != null)
                        DisplayRoadStatus(road);
                    else
                    {
                        DisplayRoadError(command);
                        TerminateApplication();
                    }
                }
            }
        }

        public void DisplayRoadStatus(Road road)
        {
            DisplayMessage("\nThe status of the " + road.displayName + " is as follows:\n");
            DisplayMessage("Road Status is: " + road.statusSeverity + "");
            DisplayMessage("Road Status Description is: " + road.statusSeverityDescription + "\n");
        }

        public void DisplayRoadError(string roadName)
        {
            DisplayMessage(roadName + " is not a valid road\n");
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayInstructions()
        {
            Console.WriteLine("Please enter the name of the road you want to know about, or type exit to terminate.");
        }

        private void TerminateApplication()
        {
            Environment.Exit(1);
        }
    }
}
