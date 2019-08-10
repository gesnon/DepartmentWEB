using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DepartmentWeb.Models
{
    public class Position
    {
        public int ID { get; set; }

        public string Title { get; set; }

        public decimal MinSalary { get; set; }

        public decimal MaxSalary { get; set; }

    }
}