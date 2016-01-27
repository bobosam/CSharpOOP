using SampleExamEmpires.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.IO
{
    public class ConsoleWriter : IOutputWriter
    {
        public void Print(string message)
        {
            Console.WriteLine(message); ;
        }
    }
}
