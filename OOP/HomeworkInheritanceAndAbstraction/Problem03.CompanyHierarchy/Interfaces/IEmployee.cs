﻿namespace Problem03.CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}
