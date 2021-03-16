using System;
using static Misc;
using static Binary;

namespace Math1BinarySystems
{
    class Math1BinarySystems
    {
        static void Main(string[] args)
        {
            // Variable Definitions
            string category = "Please select a category:", caseSwitch = "";
            bool choice = false;
            Binary b = new Binary();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            // Intro text and menu choices
            Console.WriteLine("IN521 Math 1 Chapter 1: Binary Systems\n" +
                "\n" +
                category);
            Console.Write("1.Binary\n" +
                "2.Decimal (TODO)\n" +
                "3.Hexadecimal (TODO)\n" +
                "4.Set Theory (TODO)\n" +
                "5.Digital Logic (TODO)\n" +
                "6.Computer Codes (TODO)\n" +
                "q.Close Program\n");
            // Move cursor back to colon
            Console.SetCursorPosition(category.Length + 1, 2);

            // Read userinput and check the case
            caseSwitch = Console.ReadLine();
            while (!choice)
            switch (caseSwitch)
            {
                case "1":
                        choice = true;
                        b.ConvertToDec();
                        break;

                case "2":
                        // choice = true;
                        // Todo: Add Method for Decimal here
                        Console.SetCursorPosition(category.Length + 1, 2);
                        caseSwitch = Console.ReadLine();
                        break;

                case "3":
                        // choice = true;
                        // Todo: Add Method for Hexadecimal here
                        Console.SetCursorPosition(category.Length + 1, 2);
                        caseSwitch = Console.ReadLine();
                        break;

                case "4":
                        // choice = true;
                        // Todo: Add Method for Set Theory here
                        Console.SetCursorPosition(category.Length + 1, 2);
                        caseSwitch = Console.ReadLine();
                        break;

                case "5":
                        // choice = true;
                        // Todo: Add Method for Digital Logic here
                        Console.SetCursorPosition(category.Length + 1, 2);
                        caseSwitch = Console.ReadLine();
                        break;

                case "6":
                        // choice = true;
                        // Todo: Add Method for Computer Codes
                        Console.SetCursorPosition(category.Length + 1, 2);
                        caseSwitch = Console.ReadLine();
                        break;

                case "q":
                        choice = true;
                        break;

                default:
                        // No answer given. Loop back to the top, move cursor back and grab new input.
                        Console.SetCursorPosition(category.Length + 1, 2);
                        caseSwitch = Console.ReadLine();
                        break;



            }

            Console.Clear();
            Console.WriteLine("Closing program..");
            Console.ReadLine();
        }   
    }
}
