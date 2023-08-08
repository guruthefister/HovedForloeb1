namespace Vi_håber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Table");
            Tabel();

            Console.WriteLine();

            Console.WriteLine("TheBiggestNumber");
            TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 });
            Console.WriteLine(TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 }));

            Console.WriteLine();

            Console.WriteLine("Two7sNextToEachOther");
            Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));

            Console.WriteLine();

            Console.WriteLine("ThreeIncreasingAdjacent");
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));

            Console.WriteLine();

            Console.WriteLine("SieveOfEratosthenes");
            Console.WriteLine(SivenOfEratosthenes);

            Console.WriteLine();

            Console.WriteLine("ExtractString");

            Console.WriteLine();

            Console.WriteLine("FullSequenceOfLetters");

            Console.WriteLine();

            Console.WriteLine("SumAndAverage");

            Console.WriteLine();

            Console.WriteLine("DrawTriangle");

            Console.WriteLine();

            Console.WriteLine("ToThePowerOf");
        }

        static void Tabel()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write($"{i * j} ");
                    }
                    else
                    {
                        Console.Write(i * j);
                    }
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        static int TheBiggestNumber(int[] numbers)
        {
            int number = numbers[0];
            foreach (int i in numbers)
            {
                if (i > number) number = i;
            }

            return number;
        }

        static int Two7sNextToEachOther(int[] numbers)
        {
            int numberOfSevens = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 7 && numbers[i - 1] == 7)
                {
                    numberOfSevens++;
                }
            }
            return numberOfSevens;
        }

        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] - 1 == numbers[i - 1] && numbers[i + 1] - 1 == numbers[i])
                {
                    return true;
                }
            }
            return false;
        }

        static int SivenOfEratosthenes()
        {
            
        }

        static string ExtractString(string input)
        {
            return input;
        }

        static string FullSequenceOfLetters(string input)
        {
            return input;
        }

        static int SumAndAverage(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static int DrawTriangle(int value)
        {
            return value;
        }

        static int ToThePowerOf(int value)
        {
            return value;
        }
    }
}