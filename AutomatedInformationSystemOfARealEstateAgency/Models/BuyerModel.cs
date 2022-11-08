using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Models
{
    public class BuyerModel
    {
        // Поля класса

        private Guid idOfBuyer;
        private string nameOfBuyer;
        private string serNameOfBuyer;
        private string patronymicOfBuyer;
        private int yearOfBirthOfBuyer;
        private string phoneOfBuyer;
        private string passportSeriesOfBuyer;
        private string passportNumberOfBuyer;
        private string passportSubdivisionCodeOfBuyer;


        // Свойства - Валидатор

        [DisplayName("Buyer's ID")]
        public Guid IdOfBuyer
        {
            get { return idOfBuyer; }
            set { idOfBuyer = value; }
        }

        [DisplayName("Buyer's name")]
        [Required(ErrorMessage = "Buyer's name is required")]
        public string NameOfBuyer
        {
            get { return nameOfBuyer; }
            set { nameOfBuyer = value; }
        }

        [DisplayName("Buyer's serName")]
        [Required(ErrorMessage = "Buyer's serName is required")]
        public string SerNameOfBuyer
        {
            get { return serNameOfBuyer; }
            set { serNameOfBuyer = value; }
        }

        [DisplayName("Buyer's patronymic")]
        [Required(ErrorMessage = "Buyer's patronymic is required")]
        public string PatronymicOfBuyer
        {
            get { return patronymicOfBuyer; }
            set { patronymicOfBuyer = value; }
        }

        [DisplayName("Buyer's yearOfBirth")]
        [Required(ErrorMessage = "Buyer's yearOfBirth is required")]
        public int YearOfBirthOfBuyer
        {
            get { return yearOfBirthOfBuyer; }
            set { yearOfBirthOfBuyer = value; }
        }

        [DisplayName("Buyer's PhoneOfOwner")]
        [Required(ErrorMessage = "Buyer's PhoneOfOwner is required")]
        public string PhoneOfBuyer
        {
            get { return phoneOfBuyer; }
            set { phoneOfBuyer = value; }
        }

        [DisplayName("Buyer's passportSeriesOfOwner")]
        [Required(ErrorMessage = "Buyer's passportSeriesOfOwner is required")]
        public string PassportSeriesOfBuyer
        {
            get { return passportSeriesOfBuyer; }
            set { passportSeriesOfBuyer = value; }
        }

        [DisplayName("Buyer's passportNumberOfOwner")]
        [Required(ErrorMessage = "Buyer's passportNumberOfOwner is required")]
        public string PassportNumberOfBuyer
        {
            get { return passportNumberOfBuyer; }
            set { passportNumberOfBuyer = value; }
        }

        [DisplayName("Buyer's passportSubdivisionCodeOfOwner")]
        [Required(ErrorMessage = "Buyer's passportSubdivisionCodeOfOwner is required")]
        public string PassportSubdivisionCodeOfBuyer
        {
            get { return passportSubdivisionCodeOfBuyer; }
            set { passportSubdivisionCodeOfBuyer = value; }
        }
    }
}
