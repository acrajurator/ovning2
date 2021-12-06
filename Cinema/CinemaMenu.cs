using System;

namespace Program.Cinema
{
    class CinemaMenu
    {

        private static ConsoleUI ui;
        public int SeniorPrice { get; set; }
        public int YouthPrice { get; set; }
        public int RegularPrice { get; set; }
        public CinemaMenu()
        {
            RegularPrice = 120;
            SeniorPrice = 90;
            YouthPrice = 80;
        }

        public void RunCinema(ConsoleUI ui2)
        {
            ui = ui2;
            bool loop = true;
            while (loop)
            {
                CinemaOptions();
                loop = UserInput();
            }

        }
        private void CinemaOptions()
        {
            ui.PrintString("1: To input one person");
            ui.PrintString("2: To input a group");
            ui.PrintString("0: Go back");
        }
        private bool UserInput()
        {
            String input = ui.GetInput();

            switch (input)
            {
                case "1":
                    CheckOnePerson();
                    break;
                case "2":
                    CheckGroup();
                    break;
                case "0":
                    return false;
                default:
                    ui.PrintString("Please input a number");
                    break;

            }
            return true;
        }

        private void CheckGroup()
        {
            ui.PrintString("How many people in the group? Answer in numbers");
            uint people = Util.AskForUInt("Number of People", ui);
            int price = 0;

                for (int x = 0; x < people; x++)
                {

                    ui.PrintString("Age of person #" + (x + 1) + "? Write the answer in numbers.");
                    uint age = Util.AskForUInt("Age", ui);
                    price += PriceCalc(age);


                }

                ui.PrintString("People in group: " + people + " price: " + price + "kr");

        }

        private int PriceCalc(uint age)
        {
            if (age <= 20)
            {
                return YouthPrice;
            }
            else if (age >= 64)
            {
                return SeniorPrice;
            }
            return RegularPrice;
        }

        private void CheckOnePerson()
        {
            ui.PrintString("How old is the person? Answer in numbers");
            uint age = Util.AskForUInt("Age", ui);


                if (age <= 19)
                {
                    ui.PrintString("Youth price: " + YouthPrice + "kr");
                }
                else if (age >= 65)
                {
                    ui.PrintString("Senior price: " + SeniorPrice + "kr");
                }
                else
                {
                    ui.PrintString("Regular price: " + RegularPrice + "kr");
                }
            

        }
    }
}
