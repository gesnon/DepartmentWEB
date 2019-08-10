using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DepartmentWeb.Models
{
    public class Department
    {
        public int ID { get; set; }

        [Display (Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Дата основания")]
        public DateTime DateOfCreation { get; set; }

        public virtual ICollection<Employee> Employee { get; set; } // навигационное свойство
    }
}