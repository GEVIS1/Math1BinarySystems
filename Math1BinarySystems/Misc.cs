using System;

public class Misc
{
    
        static string boxDraw(string s)
        {
            // Grab string s and draw a box around it.
            string boxedStr = "";
            // Grab length of string so we know how to pad it
            int strLength = s.Length;
            // Reduce by half of strLength so it's centered
            int consoleW = Console.WindowWidth - (strLength / 2), consoleH = Console.WindowHeight - (strLength / 2);

            // Divide the console window width by two for the pad left and pad right options -1 for the corner pieces
            boxedStr = "╔" + "".PadLeft((consoleW / 2) - 1, '═').PadRight((consoleW / 2) - 1, '═') + "╗";

      

            //╔═╗║
            return boxedStr;
        }

        public static string removeWhitespace(string str)
        {
            // Thanks stackoverflow.. I should probably learn how this works.
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }    
}
