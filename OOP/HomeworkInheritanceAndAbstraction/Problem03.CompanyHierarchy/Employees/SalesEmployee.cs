namespace Problem03.CompanyHierarchy.Employees
{
    using System.Collections.Generic;
    using System.Text;

    public class SalesEmployee : RegularEmployee
    {
        public SalesEmployee(string firstName, string lastName, long id, decimal salary, Department department, List<Sale> sales)
            : base(firstName, lastName, id, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }

        public override string ToString()
        {
            var viewSalesEmployee = new StringBuilder();

            viewSalesEmployee.AppendLine(base.ToString());
            viewSalesEmployee.AppendLine("Sales :");
            foreach (var sale in this.Sales)
            {
                viewSalesEmployee.AppendLine("\t" + sale.ToString());
            }

            return viewSalesEmployee.ToString();
        }
    }
}
