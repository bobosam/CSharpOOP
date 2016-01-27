namespace Problem01.SquareRoot
{
    using System;

    public class SquareRoot
    {
        public static void Main()
        {
            Console.Write("Enter number --> ");
            string strNumber = Console.ReadLine();
            int number;

            try
            {
                number = int.Parse(strNumber);

                if (0 > number)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double result = Math.Sqrt(number);
                Console.WriteLine("\nNumber --> {0}\nSquare root --> {1:0.00}", number, result);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("\nInvalid number! Input should be positive!");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nInput should be integer number");
            }
            finally
            {
                Console.WriteLine("\nGood bye.\n");
            }
        }
    }
}
