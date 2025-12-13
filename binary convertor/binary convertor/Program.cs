using System;

class BinaryConverter
{
    static void Main()
    {
        Console.WriteLine("===================================");
        Console.WriteLine("   BINARY CODE GENERATOR");
        Console.WriteLine("===================================");
        Console.WriteLine();

        // Ask user what they want to convert
        Console.WriteLine("What do you want to convert?");
        Console.WriteLine("1. String");
        Console.WriteLine("2. Integer");
        Console.Write("\nEnter your choice (1 or 2): ");

        string choice = Console.ReadLine();
        Console.WriteLine();

        if (choice == "1")
        {
            ConvertStringToBinary();
        }
        else if (choice == "2")
        {
            ConvertIntegerToBinary();
        }
        else
        {
            Console.WriteLine("Invalid choice! Please enter 1 or 2.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // Function to convert string to binary
    static void ConvertStringToBinary()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("\n--- Binary Representation ---");
        Console.WriteLine();

        // Convert each character to binary
        foreach (char c in input)
        {
            // Get ASCII value of character
            int ascii = (int)c;

            // Convert ASCII to binary
            string binary = Convert.ToString(ascii, 2);

            // Pad with zeros to make it 8 bits
            binary = binary.PadLeft(8, '0');

            Console.WriteLine($"'{c}' -> ASCII: {ascii} -> Binary: {binary}");
        }

        // Show complete binary string
        Console.WriteLine("\nComplete Binary String:");
        foreach (char c in input)
        {
            int ascii = (int)c;
            string binary = Convert.ToString(ascii, 2).PadLeft(8, '0');
            Console.Write(binary + " ");
        }
        Console.WriteLine();
    }

    // Function to convert integer to binary
    static void ConvertIntegerToBinary()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();

        // Try to parse the input as integer
        if (int.TryParse(input, out int number))
        {
            // Convert integer to binary
            string binary = Convert.ToString(number, 2);

            Console.WriteLine("\n--- Binary Representation ---");
            Console.WriteLine();
            Console.WriteLine($"Decimal: {number}");
            Console.WriteLine($"Binary:  {binary}");
            Console.WriteLine();

            // Show step by step conversion (optional - educational purpose)
            Console.WriteLine("Step-by-step conversion:");
            ShowBinaryConversion(number);
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid integer.");
        }
    }

    // Function to show step by step binary conversion
    static void ShowBinaryConversion(int num)
    {
        if (num == 0)
        {
            Console.WriteLine("0 / 2 = 0, Remainder: 0");
            return;
        }

        int original = num;
        int step = 1;

        while (num > 0)
        {
            int remainder = num % 2;
            num = num / 2;
            Console.WriteLine($"Step {step}: {num * 2 + remainder} / 2 = {num}, Remainder: {remainder}");
            step++;
        }

        Console.WriteLine("\nRead remainders from bottom to top to get binary!");
    }
}