using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentWeb.Models
{
    public class Department
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public DateTime DateOfCreation { get; set; }

        public virtual ICollection<Employee> Employee { get; set; } // навигационное свойство
    }
}