using System;
namespace TestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine(AddAndMultiply(2, 4, 5));

            Console.WriteLine(CtoF(-300));

            Console.WriteLine(ElementaryOperations(3, 8));

            Console.WriteLine(IsResultTheSame(9 / 3, 16 - 1));

            Console.WriteLine(ModuloOperations(8, 5, 2));

            Console.WriteLine(TheCubeOf(2));

            Console.WriteLine(SwapTwoNumbers(87, 45));
        }
        static int AddAndMultiply(int firstNumber, int secondNumber, int thirdNumber)
        {
            int output = (firstNumber + secondNumber) * thirdNumber;
            return output;
        }
        static string CtoF(double Celcius)
        {
            if (Celcius < -271)
            {
                double calc = (Celcius * 9) / 5 + 32; string output = $"F = {calc}F";
                return output;
            }
            else
            { return "Temperature below absolute zero!"; }
        }

        static string ElementaryOperations(int firstNumber, int secondNumber)
        {
            int addition = firstNumber + secondNumber;
            int substraction = firstNumber - secondNumber;
            int multiplication = firstNumber * secondNumber;
            string division = "";
            if (firstNumber != 0 || secondNumber != 0)
            {
                division = $"{(float)firstNumber / (float)secondNumber}";
            }
            else
            { division = "Illegal division by 0"; }
            return $"{addition}, {substraction}, {multiplication}, {division}";
        }
        static bool IsResultTheSame(int firstCalc, int secondCalc) 
        { 
            if (firstCalc == secondCalc) 
            { return true; } else 
            { return false; } 
        }
        static int ModuloOperations(int firstNumber, int secondNumber, int thirdNumber) 
        { 
            int output = firstNumber % secondNumber % thirdNumber; 
            return output; 
        }
        static double TheCubeOf(double value) 
        { 
            double output = value * value * value; 
            return output; 
        }
        static string SwapTwoNumbers(int firstNumber, int secondNumber) 
        { 
            int[] saveArray = { firstNumber, secondNumber }; 
            return $"Before: a = {saveArray[0]}, b = {saveArray[1]}; After: a = {saveArray[1]}, b = {saveArray[0]}"; 
        }
    }
}