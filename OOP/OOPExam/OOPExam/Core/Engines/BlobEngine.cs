using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam.Core.Engines
{
    using Commands;
    using Factories;
    using Interfaces;

    public class BlobEngine : IEngine
    {
        private IDatabase db;
        private IInputReader reader;
        private IOutputWrite writer;

        public BlobEngine(IDatabase db, IInputReader reader, IOutputWrite writer)
        {
            this.db = db;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            IExecutable command = null;
            string line = reader.ReadLine();
            while (line != "drop")
            {
                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "create":
                        command = new CreateCommand(
                            db,
                            tokens[1],
                            int.Parse(tokens[2]),
                            int.Parse(tokens[3]),
                            tokens[4],
                            tokens[5]);
                        break;
                    case "pass":
                        command = new PassCommand(db);
                        break;
                    case "status":
                        command = new StatusCommand(db);
                        break;
                    case "attack":

                    default:
                        throw new NotImplementedException("Uncnoun command.");
                }

                try
                {
                    this.writer.Print(command.Execute());
                }
                catch (Exception e)
                {
                    this.writer.Print(e.Message);
                }
                finally
                {
                    line = reader.ReadLine();
                }

            }
        }
    }
}
