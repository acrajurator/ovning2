using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public static class Util
    {
        public static string AskForInput(string prompt, ConsoleUI ui)
        {
            bool success = false;
            string answer;

            do
            {
                ui.PrintString($"{prompt}: ");
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.PrintString($"You must enter a {prompt}");
                }

                else
                {
                    success = true;
                }

            } while (!success);


            return answer;
        }

        public static uint AskForUInt(string prompt, ConsoleUI ui)
        {
            do
            {

                string input = AskForInput(prompt, ui);
                if (uint.TryParse(input, out uint answer)) return answer;

            } while (true);
        }

    }
}
