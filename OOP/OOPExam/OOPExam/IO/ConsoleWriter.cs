namespace OOPExam.IO
{
    using System;

    using Interfaces;

    public class ConsoleWriter : IOutputWrite
    {
        public void Print(string mesage)
        {
            Console.WriteLine(mesage);
        }
    }
}
