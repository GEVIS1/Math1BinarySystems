using System;

namespace Math1BinarySystems
{
    class BinarySystems
    {
        static void Main(string[] args)
        {
            // @TODO: Add boxDraw method
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            convertBintoDec();
            Console.ReadLine();
        }

        static void convertBintoDec()
        {
            string temp = "", input = "catchWhileLoop";
            int[] binaryPower = { 1, 2, 4, 8, 16, 32, 64, 128 };
            byte binaryResult = 0;
            int result = 0;

            Console.WriteLine("Binary to Decimal.\n" +
                "Converting Binary to Decimal is done by adding all the binary digits together as their place value to get the decimal number.\n" +
                "\n" +
                "\n" +
                "Place value:\t128\t64\t32\t16\t8\t4\t2\t1\n" +
                "Binary value:\t1¹²⁸\t1⁶⁴\t0³²\t1¹⁶\t0⁸\t1⁴\t1²\t0¹\n" +
                "\n" +
                "E.G.\n" +
                "\n" +
                "11010110₂\t= 128 + 64 + 16 + 4 + 2\n" +
                "\t\t= 214₂\n"
                );
            Console.Write("Input an 8-bit binary number you want to convert to decimal: ");

            // Keep entering numbers until a valid size is given.
            while (input.Length > 8)
            {
                temp = Console.ReadLine();
                input = removeWhitespace(temp);
            }

            // If the user inputs a binary number with less than 8 digits, pad the missing left digits with zeroes
            if (input.Length < 8) input = input.PadLeft(8 - input.Length, '0');
            binaryResult = Convert.ToByte(input,2);
                
            // Give the result and explain how it got to the result
            Console.WriteLine($"You input {temp}₂ which equals {binaryResult}₁₀\n" +
                "We got to this result by adding together the bit values like follows:\n" +
                $"{input[7]}\t{input[6]}\t{input[5]}\t{input[4]}\t{input[3]}\t{input[2]}\t{input[1]}\t{input[0]}\n" +
                 "*\t*\t*\t*\t*\t*\t*\t*\n" +
                 "128\t64\t32\t16\t8\t4\t2\t1\n" +
                 "=\t=\t=\t=\t=\t=\t=\t=\n" +
                 $"{input[7] * 128}\t{input[6] * 64}\t{input[5] * 32}\t{input[4] * 16}\t{input[3] * 8}\t{input[2] * 4}\t{input[1] * 2}\t{input[0] * 1}\n");
            
        }

        public static string removeWhitespace(string str)
        {
            // Thanks stackoverflow..
            return string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
        }

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

    
    }
}
