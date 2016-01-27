using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.IO
{
    using SampleExamEmpires.Contracts;
    public class ConsoleReader : IInputReader
    {
        public string ReadLine()
        {
            string line = Console.ReadLine();

            return line;
        }
    }
}
