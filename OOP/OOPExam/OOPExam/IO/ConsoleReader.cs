namespace OOPExam.IO
{
    using System;

    using Interfaces;

    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string commandLine = Console.ReadLine();

            return commandLine;
        }
    }
}
