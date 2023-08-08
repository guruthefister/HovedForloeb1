internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Console.WriteLine(AbsoluteValue(-392));

        Console.WriteLine(DivisibleBy2Or3(15, 30));

        Console.WriteLine(IfConsistsOfUppercaseLetters("L9#"));

        Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 }));

        Console.WriteLine(IfNumberIsEven(721));

        Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 }));

        Console.WriteLine(PositiveNegativeOrZero(0.0));

        Console.WriteLine(IfYearIsLeap(2016));
    }

    static int AbsoluteValue(int value)
    {
        int output = Math.Abs(value);
        return output;
    }

    static int DivisibleBy2Or3(int numberA, int numberB)
    {
        int result;

        if (numberA % 2 == 0 && numberB % 2 == 0 || numberA % 3 == 0 && numberB % 3 == 0)
        {
            result = numberA * numberB;
        }
        else
        {
            result = numberA + numberB;
        }

        return result;
    }

    static bool IfConsistsOfUppercaseLetters(string value)
    {
        bool isUpper = true;

        foreach (char c in value)
        {
            if (!char.IsUpper(c)) isUpper = false;
        }

        return isUpper;
    }

    static bool IfGreaterThanThirdOne(int[] values)
    {
        int mulitiply = values[0] * values[1];
        int addition = values[0] + values[1];

        if (mulitiply > values[2] || addition > values[2])
        {
            return true;
        } else
        {
            return false;
        }
    }

    static bool IfNumberIsEven(int value)
    {
        int output = value % 2;
        if (output == 0)
        {
            return true;
        } else
        {
            return false;
        }
    }

    static bool IfSortedAscending(int[] values)
    {
        for (int i = 1; i < values.Length; i++)
        {
            if (values[i - 1] > values[i])
            {
                return false;
            }
        }
        return true;
    }

    static string PositiveNegativeOrZero(double value)
    {
        if (value != 0)
        {
            if (Math.Abs(value) == value)
            {
                return "Positive";
            }
            else
            {
                return "Negative";
            }
        }else
        {
            return "Zero";
        }
    }

    static bool IfYearIsLeap(int year)
    {
        if (year % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}