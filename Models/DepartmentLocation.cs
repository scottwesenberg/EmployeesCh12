﻿namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        public int DepartmentID { get; set; }
        public int LocationID { get; set; }

        //navigation properties
        public Department Department { get; set; } = null!;
        public Location Location { get; set; } = null!;
    }
}
