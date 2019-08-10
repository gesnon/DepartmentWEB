using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DepartmentWeb.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display (Name = "Имя")]
        public string FirstName { get; set; }

        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Display(Name = "Пол")]
        public Sex Sex { get; set; }

        [Display(Name = "Дата рождения")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Телефон")]
        public string Phone { get; set; }

        [Display(Name = "Эл. почта")]
        public string Mail { get; set; }

        [Display(Name = "Дата принятия")]
        public DateTime DateOfEmployment { get; set; }

        [Display(Name = "Дата увольнения")]
        public DateTime? DateOfDismissal { get; set; }
        
        [Display(Name = "Зарплата")]
        public decimal Salary { get; set; }

        [Display(Name = "Начальник")]
        public bool Boss { get; set; }

        public int PositionID { get; set; }

        public int DepartmentID { get; set; }

        [Display(Name = "Департамент")]
        public virtual Department Department { get; set; }  // навигационное свойство

        [Display(Name = "Должность")]
        public virtual Position Position { get; set; }

    }

}