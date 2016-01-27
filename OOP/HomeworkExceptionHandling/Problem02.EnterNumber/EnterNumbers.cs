namespace Problem02.EnterNumbers
{
    using System;

    public class EnterNumbers
    {
        public const int Start = 1;
        public const int End = 100;
        public const int CountOfNumbers = 10;

        public static void Main()
        {
            int[] numbers = new int[CountOfNumbers];
            bool checkNumber;
            int number = 0;

            for (int i = 0; i < CountOfNumbers; i++)
            {
                do
                {
                    checkNumber = false;

                    try
                    {
                        Console.Write("Number{0} --> ", i + 1);
                        number = ReadNumber(Start, End);

                        if (0 < i)
                        {
                            if (number <= numbers[i - 1])
                            {
                                throw new ArithmeticException();
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("The number should be integer number!");
                        Console.WriteLine("Try again!");
                        checkNumber = true;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The number should be in range [{0}...{1}]", Start, End);
                        Console.WriteLine("Try again!");
                        checkNumber = true;
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("The number should be greater then {0}", numbers[i - 1]);
                        Console.WriteLine("Try again!");
                        checkNumber = true;
                    }
                }
                while (checkNumber);

                numbers[i] = number;
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine();
        }

        private static int ReadNumber(int start, int end)
        {
            string line = Console.ReadLine();
            int number = int.Parse(line);
            if (start > number || end < number)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number;
        }
    }
}
