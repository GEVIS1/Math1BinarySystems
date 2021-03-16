using System;
using static Misc;

/// <summary>
/// TODO
/// Add methods for Binary Fractions, Binary Addition, Signed Binary, Binary to Hex, and Binary status flags.
/// </summary>
public class Binary
{
	public void ConvertToDec()
        {
            string temp = "", input = "catchWhileLoop", choice = "";
            int[] binaryPower = { 1, 2, 4, 8, 16, 32, 64, 128 };
            byte binaryResult = 0;

            // Clear console of previous text
            Console.Clear();
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
            Console.Write("Input an 8-bit unsigned binary number you want to convert to decimal: ");

            // Keep entering numbers until a valid size is given.
            while (input.Length > 8)
            {
                temp = Console.ReadLine();
            // If the user inputs nothing, read it as 0000 0000.
            if (temp == "") temp = "0000 0000";
                input = removeWhitespace(temp);
            }

            // If the user inputs a binary number with less than 8 digits, pad the missing left digits with zeroes
            if (input.Length < 8) input = input.PadLeft(8 - input.Length, '0');
            binaryResult = Convert.ToByte(input, 2);

            // Give the result and explain how it got to the result
            Console.WriteLine($"You input {temp}₂ which equals {binaryResult}₁₀\n" +
                "We got to this result by adding together the bit values like follows:\n\n" +
                $"{input[0]}\t{input[1]}\t{input[2]}\t{input[3]}\t{input[4]}\t{input[5]}\t{input[6]}\t{input[7]}\n" +
                 "*\t*\t*\t*\t*\t*\t*\t*\n" +
                 "128\t64\t32\t16\t8\t4\t2\t1\n" +
                 "=\t=\t=\t=\t=\t=\t=\t=\n" +
                 $"{Int32.Parse(input[0].ToString()) * 128} +\t{Int32.Parse(input[1].ToString()) * 64}  +\t{Int32.Parse(input[2].ToString()) * 32}  +\t{Int32.Parse(input[3].ToString()) * 16}  +\t{Int32.Parse(input[4].ToString()) * 8}   +\t{Int32.Parse(input[5].ToString()) * 4}   +\t{Int32.Parse(input[6].ToString()) * 2}   +\t{Int32.Parse(input[7].ToString()) * 1}\t=\t{binaryResult}₁₀\n");

            // @TODO: Make a while loop to let user input several binary numbers
            Console.Write("TODO: This does nothing at the moment.. " +                
                "Do you want to input another binary number? ");
            choice = Console.ReadLine();
        }
}
