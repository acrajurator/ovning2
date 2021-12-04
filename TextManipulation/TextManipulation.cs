using System.Text.RegularExpressions;

namespace Program.Manipulation
{
    public class TextManipulation
    {

        private static ConsoleUI ui;
        public void RunTextManipulation(ConsoleUI ui2)
        {
            ui = ui2;

            SplitTextInput();
            SplitIntoWords();



        }
        private void SplitIntoWords()
        {
            while (true)
            {
                string input = ui.GetInput();
                string[] strings = input.Split(new[] { ';', ' ' }, System.StringSplitOptions.RemoveEmptyEntries);

                if (strings.Length >= 3)
                {
                    ui.PrintString("The third word was " + strings[2]);
                    break;

                }
                else
                {
                    SplitTextInput();
                }
            }
        }

        private void SplitTextInput()
        {
            ui.PrintString("write a sentence with at least 3 words");
        }

    }
}