using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentWeb.Models
{
    public class Employee
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public Sex Sex { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public DateTime DateOfEmployment { get; set; }

        public DateTime? DateOfDismissal { get; set; }

        public int PositionID { get; set; }

        public decimal Salary { get; set; }

        public bool Boss { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }  // навигационное свойство

        public virtual Position Position { get; set; }

    }

}