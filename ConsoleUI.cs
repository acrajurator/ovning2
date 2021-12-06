using System;

namespace Program
{
    public class ConsoleUI
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void PrintString(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintSameRow(string message)
        {
            Console.Write(message);
        }
    }


    
}
