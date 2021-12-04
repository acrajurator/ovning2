using System;
using Program.Cinema;
using Program.Manipulation;
using Program.Repeat;

namespace Program
{

    class Menu
    {
        private static ConsoleUI ui = new ConsoleUI();
        public void RunMenu()
        {

            while (true)
            {
                ShowMainMenu();
                UserInput();
            }


        }

        private void UserInput()
        {
            String input = ui.GetInput();

            switch (input)
            {
                case "1":
                    //om det är ett stort program tänkte jag det är bättre att ladda subparts när de behövs
                    CinemaMenu CinMenu = new CinemaMenu();
                    CinMenu.RunCinema(ui);
                    break;
                case "2":
                    RepeatText ReText = new RepeatText();
                    ReText.RunRepeatText(ui);
                    break;
                case "3":
                    TextManipulation TextMan = new TextManipulation();
                    TextMan.RunTextManipulation(ui);
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    //output error
                    break;

            }
        }




        private void ShowMainMenu()
        {
            ui.PrintString("1: Go to Cinema");
            ui.PrintString("2: Repeat users input 10 times");
            ui.PrintString("3: Pick third word from users input");
            ui.PrintString("0: Quit");
        }
    }




}
