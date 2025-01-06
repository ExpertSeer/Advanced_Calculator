using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string op1;
                Console.WriteLine();
                Console.WriteLine("Advanced Calulation Program==================================================================");
                Console.WriteLine("For Basic Calculations(Addition, Substraction, Multiplication, Division and Modulus) Press:  A");
                Console.WriteLine("For Calculation of Nth Root Or Power of Nth of any Number Press:  B");
                Console.WriteLine("For ASCII Values Conversion Press: C");
                Console.WriteLine("For Number System Conversions Press:  D");
                Console.WriteLine("Want to Clear Previous Output Press:  F");
                Console.WriteLine("For Exit the Program Press:  E");
                op1 = Console.ReadLine();
                if(string.IsNullOrEmpty(op1))
                {
                    Console.WriteLine("You can't give a Blank Input");
                }
                else
                {
                    //char op2 = op1.ToCharArray()[0];
                    char op2 = op1[0];
                    op2 = char.ToUpper(op2);
                    switch(op2)
                    {
                        case 'A':
                            Basic();
                            break;
                        case 'B':
                            Nth();
                            break;
                        case 'C':
                            Asci();
                            break;
                        case 'D':
                            Ds();
                            break;
                        case 'E':
                            return;
                        case 'F':
                            Console.Clear();
                            break;
                        default: Console.WriteLine("You have enter the Invalid Option");
                            break;
                    }
                }
            }
        }
        static void Basic()
        {
            char value1;
            string value2;
            double x, y, temp1;
            Console.WriteLine("Enter the Basic Calculation Character for Further Operation \nFor Addition Input '+' \nFor Substraction Input '-' \nFor Multiplication Input '*' \nFor Division Input '/' \nFor Modulus Input '%'");
            value1 = Console.ReadLine()[0];
            switch (value1)
            {
                case '+':
                    try
                    {
                        Console.WriteLine("Enter 2 Addends for Addition");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Add(x, y);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }
                    break;
                case '-':
                    try
                    {
                        Console.WriteLine("Enter Minuend and Subtrahend for Substraction");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Sub(x, y);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }
                    break;
                case '*':
                    try
                    {
                        Console.WriteLine("Enter Multiplicand and Multiplicator for Multiplication");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Mul(x, y);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }
                    break;
                case '/':
                    try
                    {
                        Console.WriteLine("Enter Dividend and Divisor for Division");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Div(x, y);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }
                    break;
                case '%':
                    try
                    {
                        Console.WriteLine("Enter Dividend and Divisor for Modulus");
                        x = double.Parse(Console.ReadLine());
                        y = double.Parse(Console.ReadLine());
                        Mod(x, y);
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }
                    break;
                default:
                    Console.WriteLine("You have Entered Invalid Character");
                    break;

            }
            void Add(double a, double b)
            {
                double c = 0;
                c = a + b;
                Console.WriteLine($"Sum: {c}");
                Console.WriteLine("If you want to Continue the Operation Further Press: 1 Or Want to leave Press any key");
                value2 = Console.ReadLine();
                if (value2 == "1")
                {
                    Console.WriteLine("Enter next Digit");
                    temp1 = double.Parse(Console.ReadLine());
                    Add(c, temp1);
                }
                else
                {
                    return;
                }
            }
            void Sub(double a, double b)
            {
                double c = 0;
                c = a - b;
                Console.WriteLine($"Difference: {c}");
                Console.WriteLine("If you want to Continue the Operation Further Press: 1 Or Want to leave Press any key");
                value2 = Console.ReadLine();
                if (value2 == "1")
                {
                    Console.WriteLine("Enter next Digit");
                    temp1 = double.Parse(Console.ReadLine());
                    Sub(c, temp1);
                }
                else
                {
                    return;
                }
            }
            void Mul(double a, double b)
            {
                double c = 1;
                c = a * b;
                Console.WriteLine($"Product: {c}");
                Console.WriteLine("If you want to Continue the Operation Further Press: 1 Or Want to leave Press any key");
                value2 = Console.ReadLine();
                if (value2 == "1")
                {
                    Console.WriteLine("Enter next Digit");
                    temp1 = double.Parse(Console.ReadLine());
                    Mul(c, temp1);
                }
                else
                {
                    return;
                }
            }
            void Div(double a, double b)
            {
                double c = 1;
                if (b != 0)
                {
                    c = a / b;
                    Console.WriteLine($"Quotient: {c}");
                    Console.WriteLine("If you want to Continue the Operation Further Press: 1 Or Want to leave Press any key");
                    value2 = Console.ReadLine();
                    if (value2 == "1")
                    {
                        Console.WriteLine("Enter next Digit");
                        temp1 = double.Parse(Console.ReadLine());
                        Div(c, temp1);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("The Division by 0 is not Possible");
                }
            }
            void Mod(double a, double b)
            {
                double c = 1;
                if (b != 0)
                {
                    c = a % b;
                    Console.WriteLine($"Remainder: {c}");
                    Console.WriteLine("If you want to Continue the Operation Further Press: 1 Or Want to leave Press any key");
                    value2 = Console.ReadLine();
                    if (value2 == "1")
                    {
                        Console.WriteLine("Enter next Digit");
                        temp1 = double.Parse(Console.ReadLine());
                        Mod(c, temp1);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("The Division by 0 is not Possible");
                }
            }
           
        }
        static void Nth()
        {
            string value1;
            char value2;
            double num1, po, ro, result=0;
            Console.WriteLine("Enter R to Find root of a number||Enter P to Find Power of a number");
            value1 = Console.ReadLine();
            if (string.IsNullOrEmpty(value1))
            {
                Console.WriteLine("You can't give a Blank Input");
            }
            else
            {
                value2 = value1.ToCharArray()[0];
                value2 = char.ToUpper(value2);
                if (value2 == 'R')
                {
                    try
                    {
                        Console.WriteLine("Enter the Number and Root value for calculation");
                        num1 = double.Parse(Console.ReadLine());
                        ro = double.Parse(Console.ReadLine());
                        result = Math.Pow(num1, 1 / ro);
                        Console.WriteLine($"The {ro}th Root of {num1}:  {result}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }

                }
                else if (value2 == 'P')
                {
                    try
                    {
                        Console.WriteLine("Enter the Number and Power value for calculation");
                        num1 = double.Parse(Console.ReadLine());
                        po = double.Parse(Console.ReadLine());
                        result = Math.Pow(num1, po);
                        Console.WriteLine($"The {po}th Power of {num1}:  {result}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You can Enter Float or Integer values only");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the Valid value");
                }
            }
        }
        static void Asci()
        {
            char value;
            string op;
            Console.WriteLine("Enter the value which ASCII Digit you want to Know");
            value = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"The ASCII value of a {value} is:  {(int)value}");
            Console.WriteLine("Want to Know more ASCII values then Press 1 or Press any other value to return back");
            op = Console.ReadLine();
            if(op=="1")
            {
                Asci();
            }
            else 
            {
                return;
            }
        }
        static void Ds()
        {
            string input;
            Console.WriteLine("Enter the Number for Coversion(Add 0 as prefix for Octal numbers)");
            input = Console.ReadLine();
            if (IsBinary(input))
            {
                try
                {
                    // Convert binary to decimal
                    int decimalValue = Convert.ToInt32(input, 2);

                    // Convert decimal to octal
                    string octalValue = Convert.ToString(decimalValue, 8);

                    // Convert decimal to hexadecimal
                    string hexValue = Convert.ToString(decimalValue, 16).ToUpper();

                    // Display results
                    Console.WriteLine($"Binary: {input}");
                    Console.WriteLine($"Decimal: {decimalValue}");
                    Console.WriteLine($"Octal: {octalValue}");
                    Console.WriteLine($"Hexadecimal: {hexValue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid binary number. Please enter a valid binary number (e.g., 10101).");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The binary number is too large to process.");
                }

            }
            else if (IsOctal(input))
            {
                // Convert Octal to Decimal
                int decimalValue;
                try
                {
                    decimalValue = Convert.ToInt32(input, 8);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid Octal Number: {ex.Message}");
                    return;
                }

                // Convert Decimal to Binary
                string binaryValue = Convert.ToString(decimalValue, 2);

                // Convert Decimal to Hexadecimal
                string hexValue = Convert.ToString(decimalValue, 16).ToUpper();

                // Display the results
                Console.WriteLine($"Octal Number: {input}");
                Console.WriteLine($"Decimal Equivalent: {decimalValue}");
                Console.WriteLine($"Binary Equivalent: {binaryValue}");
                Console.WriteLine($"Hexadecimal Equivalent: {hexValue}");
            }
            else if (IsDecimal(input))
            {
               
                    Console.WriteLine($"Decimal: {input}");
                    int input2 = Convert.ToInt32(input);
                    Console.WriteLine($"Binary: {Convert.ToString(input2, 2)}");
                    Console.WriteLine($"Octal: {Convert.ToString(input2, 8)}");
                    Console.WriteLine($"Hexadecimal: {Convert.ToString(input2, 16).ToUpper()}");
               
            }
            
            else if (IsHexadecimal(input))
            {
                try
                {
                    // Convert hexadecimal to decimal
                    int decimalValue = Convert.ToInt32(input, 16);

                    // Convert decimal to binary
                    string binaryValue = Convert.ToString(decimalValue, 2);

                    // Convert decimal to octal
                    string octalValue = Convert.ToString(decimalValue, 8);

                    Console.WriteLine($"\nHexadecimal: {input}");
                    Console.WriteLine($"Decimal: {decimalValue}");
                    Console.WriteLine($"Binary: {binaryValue}");
                    Console.WriteLine($"Octal: {octalValue}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid hexadecimal number. Please try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large to process.");
                }
            }
            else
            {
                Console.WriteLine("The number does not match any of the specified bases.");
            }
        }
        static bool IsBinary(string num)
        {
            foreach (char ch in num)
            {
                if (ch != '0' && ch != '1')
                    return false;
            }
            return true;
        }
        static bool IsDecimal(string num)
        {
            foreach (char ch in num)
            {
                if (!char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        static bool IsOctal(string num)
        {
            return num.StartsWith("0") && IsDigitsWithinRange(num);
            bool IsDigitsWithinRange(string num2)
            {
                foreach (char c in num2)
                {
                    if (c < '0' || c > '7') // Restricting to 0-7 for octal
                        return false;
                }
                return true;
            }
        }
        static bool IsHexadecimal(string num)
        {
            foreach (char ch in num)
            {
                if (!char.IsDigit(ch) && !(ch >= 'A' && ch <= 'F') && !(ch >= 'a' && ch <= 'f'))
                    return false;
            }
            return true;
        }
    }
}
