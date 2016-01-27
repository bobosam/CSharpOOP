using SampleExamEmpires.Core;
using SampleExamEmpires.Core.Factories;
using SampleExamEmpires.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires
{
    public class EmpiresApplication
    {
        public static void Main(string[] args)
        {
            var buildingFactory = new BuildingFactory();
            var unitFactory = new UnitFactory();
            var resourceFactory = new ResourceFactory();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();
            var db = new Database();

            var engine = new Engine(
                buildingFactory,
                resourceFactory,
                unitFactory,
                db,
                reader,
                writer);

            engine.Run();
        }
    }
}
