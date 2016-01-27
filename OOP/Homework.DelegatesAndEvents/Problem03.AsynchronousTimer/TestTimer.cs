namespace Problem03.AsynchronousTimer
{
    using System;

    public class TestTimer
    {
        public static void Work1(string str)
        {
            Console.Write(str);
        }

        public static void Work2(string str)
        {
            Console.Beep();
        }

        public static void Main()
        {
            AsyncTimer timer1 = new AsyncTimer(Work1, 10, 1000);
            timer1.Start();

            AsyncTimer timer2 = new AsyncTimer(Work2, 25, 500);
            timer2.Start();
        }
    }
}
