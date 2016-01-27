namespace Problem03.CompanyHierarchy.Employees
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Developer : RegularEmployee
    {
        public Developer(
            string firstName,
            string lastName,
            long id,
            decimal salary,
            Department department,
            List<Project> projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = projects;
        }

        public List<Project> Projects { get; set; }

        public void CloseProject(string name)
        {
            var project = this.Projects.Where(p => p.Name == name).First();
            project.State = ProjectState.Closed;
        }

        public override string ToString()
        {
            var viewDeveloper = new StringBuilder();

            viewDeveloper.AppendLine(base.ToString());
            viewDeveloper.Append("Projects :");
            foreach (var project in this.Projects)
            {
                viewDeveloper.AppendLine("\t" + project.ToString());
            }

            return viewDeveloper.ToString();
        }
    }
}
