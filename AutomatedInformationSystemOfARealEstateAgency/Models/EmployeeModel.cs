using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Models
{
    /// <summary>
    /// Класс, описывающий сущность - сотрудник
    /// </summary>
    public class EmployeeModel
    {
        // Поля класса

        private Guid idOfEmployee;
        private string nameOfEmployee;
        private string serNameOfEmployee;
        private string patronymicOfEmployee;
        private int yearOfBirthOfEmployee;
        private string loginOfEmployee;
        private string passwordOfEmployee;


        // Свойства - Валидатор

        [DisplayName("Employee's ID")]
        public Guid IdOfEmployee
        {
            get { return idOfEmployee; }
            set { idOfEmployee = value; }
        }

        [DisplayName("Employee's name")]
        [Required(ErrorMessage = "Employee's name is required")]
        public string NameOfEmployee
        {
            get { return nameOfEmployee; }
            set { nameOfEmployee = value; }
        }

        [DisplayName("Employee's serName")]
        [Required(ErrorMessage = "Employee's serName is required")]
        public string SerNameOfEmployee
        {
            get { return serNameOfEmployee; }
            set { serNameOfEmployee = value; }
        }

        [DisplayName("Employee's patronymic")]
        [Required(ErrorMessage = "Employee's patronymic is required")]
        public string PatronymicOfEmployee
        {
            get { return patronymicOfEmployee; }
            set { patronymicOfEmployee = value; }
        }

        [DisplayName("Employee's yearOfBirth")]
        [Required(ErrorMessage = "Employee's yearOfBirth is required")]
        public int YearOfBirthOfEmployee
        {
            get { return yearOfBirthOfEmployee; }
            set { yearOfBirthOfEmployee = value; }
        }

        [DisplayName("Employee's Login")]
        [Required(ErrorMessage = "Employee's Login is required")]
        public string LoginOfEmployee
        {
            get { return loginOfEmployee; }
            set { loginOfEmployee = value; }
        }

        [DisplayName("Employee's password")]
        [Required(ErrorMessage = "Employee's password is required")]
        public string PasswordOfEmployee
        {
            get { return passwordOfEmployee; }
            set { passwordOfEmployee = value; }
        }
    }
}
