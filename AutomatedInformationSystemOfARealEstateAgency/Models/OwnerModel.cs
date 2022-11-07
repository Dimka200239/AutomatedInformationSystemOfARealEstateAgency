using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Models
{
    public class OwnerModel
    {
        // Поля класса

        private Guid idOfOwner;
        private string nameOfOwner;
        private string serNameOfOwner;
        private string patronymicOfOwner;
        private int yearOfBirthOfOwner;
        private string phoneOfOwner;
        private string passportSeriesOfOwner;
        private string passportNumberOfOwner;
        private string passportSubdivisionCodeOfOwner;


        // Свойства - Валидатор

        [DisplayName("Owner's ID")]
        public Guid IdOfOwner
        {
            get { return idOfOwner; }
            set { idOfOwner = value; }
        }

        [DisplayName("Owner's name")]
        [Required(ErrorMessage = "Owner's name is required")]
        public string NameOfOwner
        {
            get { return nameOfOwner; }
            set { nameOfOwner = value; }
        }

        [DisplayName("Owner's serName")]
        [Required(ErrorMessage = "Owner's serName is required")]
        public string SerNameOfOwner
        {
            get { return serNameOfOwner; }
            set { serNameOfOwner = value; }
        }

        [DisplayName("Owner's patronymic")]
        [Required(ErrorMessage = "Owner's patronymic is required")]
        public string PatronymicOfOwner
        {
            get { return patronymicOfOwner; }
            set { patronymicOfOwner = value; }
        }

        [DisplayName("Owner's yearOfBirth")]
        [Required(ErrorMessage = "Owner's yearOfBirth is required")]
        public int YearOfBirthOfOwner
        {
            get { return yearOfBirthOfOwner; }
            set { yearOfBirthOfOwner = value; }
        }

        [DisplayName("Owner's PhoneOfOwner")]
        [Required(ErrorMessage = "Owner's PhoneOfOwner is required")]
        public string PhoneOfOwner
        {
            get { return phoneOfOwner; }
            set { phoneOfOwner = value; }
        }

        [DisplayName("Owner's passportSeriesOfOwner")]
        [Required(ErrorMessage = "Owner's passportSeriesOfOwner is required")]
        public string PassportSeriesOfOwner
        {
            get { return passportSeriesOfOwner; }
            set { passportSeriesOfOwner = value; }
        }

        [DisplayName("Owner's passportNumberOfOwner")]
        [Required(ErrorMessage = "Owner's passportNumberOfOwner is required")]
        public string PassportNumberOfOwner
        {
            get { return passportNumberOfOwner; }
            set { passportNumberOfOwner = value; }
        }

        [DisplayName("Owner's passportSubdivisionCodeOfOwner")]
        [Required(ErrorMessage = "Owner's passportSubdivisionCodeOfOwner is required")]
        public string PassportSubdivisionCodeOfOwner
        {
            get { return passportSubdivisionCodeOfOwner; }
            set { passportSubdivisionCodeOfOwner = value; }
        }
    }
}
