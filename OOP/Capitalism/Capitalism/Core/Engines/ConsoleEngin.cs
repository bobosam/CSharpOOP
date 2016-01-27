using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitalism.Core.Engines
{
    using Commands;
    using Interfaces;

    public class ConsoleEngin : IEngine
    {
        private IDatabase db;
        public ConsoleEngin(IDatabase db)
        {
            this.db = db;
        }

        public void Run()
        {

            IExecutable command = null;
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "create-company":
                        command = new CreateCompany(db, tokens[1], tokens[2], tokens[3], decimal.Parse(tokens[4]));
                        break;
                    case "create-employee":
                        string departmentName = null;
                        if (tokens.Length > 5)
                        {
                            departmentName = tokens[5];
                        }
                        command = new CreateEmployee(db, tokens[1], tokens[2], tokens[3], tokens[4], departmentName);
                        break;
                    case "create-department":
                        string mainDepartmentName = null;
                        if (tokens.Length > 5)
                        {
                            mainDepartmentName = tokens[5];
                        }
                        command = new CreateDepartment(db, tokens[1], tokens[2], tokens[3], tokens[4], mainDepartmentName);
                        break;
                    case "pay-salaries":
                        command = new PaySalaries(db, tokens[1]);
                        break;
                    case "show-employees":
                        command = new ShowEmployees(db, tokens[1]);
                        break;
                    default:
                        throw new ArgumentException("Unknoun command");
                }

                try
                {
                    Console.Write(command.Execute());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    line = Console.ReadLine();
                }
            }
        }
    }
}
