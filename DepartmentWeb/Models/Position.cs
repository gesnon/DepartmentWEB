using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DepartmentWeb.Models
{
    public class Position
    {
        public int ID { get; set; }

        [Display (Name = "Название")]
        public string Title { get; set; }

        [Display(Name = "Мин. ЗП")]
        public decimal MinSalary { get; set; }

        [Display(Name = "Макс. ЗП")]
        public decimal MaxSalary { get; set; }

    }
}