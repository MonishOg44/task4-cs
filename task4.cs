//1. Reverse a String (Using Logic)

using System;

class Program
{
    static void Main()
    {
        string str = "hello";
        string rev = "";

        for (int i = str.Length - 1; i >= 0; i--)
        {
            rev += str[i];
        }

        Console.WriteLine("Reversed String: " + rev);
    }
}

//2. Check Palindrome Number

using System;

class Program
{
    static void Main()
    {
        int num = 121;
        int temp = num;
        int rev = 0;

        while (num > 0)
        {
            rev = rev * 10 + num % 10;
            num /= 10;
        }

        if (temp == rev)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}

//3. Factorial of a Number

using System;

class Program
{
    static void Main()
    {
        int n = 5;
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
        }

        Console.WriteLine("Factorial = " + fact);
    }
}

//4. Divide Two Numbers with Exception Handling

using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result = " + (a / b));
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter numeric values only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}

//5Read a File and Handle File Not Found Exception

using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            string content = File.ReadAllText(path);

            Console.WriteLine(content);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File does not exist.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}