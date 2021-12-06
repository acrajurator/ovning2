namespace Program.Repeat
{
    class RepeatText
    {
        private static ConsoleUI ui;
        public void RunRepeatText(ConsoleUI ui2)
        {
            ui = ui2;
            RepeatableText();
            TextToRepeat();


        }

        private void TextToRepeat()
        {
            string input = ui.GetInput();
            for (int x = 0; x < 10; x++)
            {
                ui.PrintSameRow((x+1) + "." + input + " ");
            }
            ui.PrintString(" ");

        }

        private void RepeatableText()
        {
            ui.PrintString("write the text you want to repeat.");
        }

    }
}
