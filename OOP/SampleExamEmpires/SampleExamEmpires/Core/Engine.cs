using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamEmpires.Core
{
    using Contracts;
    using Models.Buildings;
    public class Engine : IRunnable
    {
        private IBuildingFactory buildingFactory;
        private IResourceFactory resourceFactory;
        private IUnitFactory unitFactory;
        private IDatabase db;
        private IInputReader reader;
        private IOutputWriter writer;

        public Engine(
            IBuildingFactory buildingFactory,
            IResourceFactory resourceFactory,
            IUnitFactory unitFactory,
            IDatabase db,
            IInputReader reader,
            IOutputWriter writer)
        {
            this.buildingFactory = buildingFactory;
            this.resourceFactory = resourceFactory;
            this.unitFactory = unitFactory;
            this.db = db;
            this.reader = reader;
            this.writer = writer;
        }
        //To Do prop for null;
        public void Run()
        {
           while(true)
            {
                string[] input = this.reader.ReadLine().Split();

                this.ExecuteCommand(input);
                this.UpdateBuildings();
            }
        }

        private void UpdateBuildings()
        {
            foreach (var building in db.Buildings)
            {
                building.Update();
                if (building.CanResourceProduce)
                {
                    var resource = building.ProduceResource();
                    this.db.Resources[resource.ResourceType] += resource.Quantity;
                }

                if (building.CanProduceUnit)
                {
                    var unit = building.ProduceUnit();
                    this.db.AddUnit(unit);
                }
            }
        }

        private void ExecuteCommand(string[] input)
        {
            switch (input[0])
            {
                case "empire-status":
                    this.ExecuteStatusCommand();
                    break;
                case "armistice":
                    Environment.Exit(0);
                    break;
                case "skip":
                    break;
                case "build":
                    this.ExecuteBuildCommand(input[1]);
                    break;
                default:
                    throw new ArgumentException("Unknown command.");
            }
        }

        private void ExecuteBuildCommand(string buildingType)
        {
            IBuilding building = this.buildingFactory.CreateBuilding(buildingType, this.unitFactory, this.resourceFactory);
            this.db.AddBuilding(building);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Treasury:");

            foreach (var resource in this.db.Resources)
            {
                output.AppendFormat($"--{resource.Key}: {resource.Value}{Environment.NewLine}");
            }

            output.AppendLine("Buildings:");

            if (this.db.Buildings.Any())
            {
                foreach (var building in this.db.Buildings)
                {
                    output.AppendLine(building.ToString());
                }
            }
            else
            {
                output.AppendLine("N/A");
            }

            output.AppendLine("Units:");

            if (this.db.Units.Any())
            {
                foreach (var unit in this.db.Units)
                {
                    output.AppendFormat($"--{unit.Key}: {unit.Value}{Environment.NewLine}");
                }
            }
            else
            {
                output.AppendLine("N/A");
            }

            this.writer.Print(output.ToString().Trim());
        }
    }
}
