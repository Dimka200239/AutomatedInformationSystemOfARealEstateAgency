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
        [Required(ErrorMessage = "Требуется имя покупателя")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Имя покупателя должно содержать от 3 до 50 символов")]
        public string NameOfBuyer
        {
            get { return nameOfBuyer; }
            set { nameOfBuyer = value; }
        }

        [DisplayName("Buyer's serName")]
        [Required(ErrorMessage = "Требуется фамилия покупателя")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Фамилия покупателя должно содержать от 4 до 50 символов")]
        public string SerNameOfBuyer
        {
            get { return serNameOfBuyer; }
            set { serNameOfBuyer = value; }
        }

        [DisplayName("Buyer's patronymic")]
        [Required(ErrorMessage = "Требуется отчество покупателя")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Отчество покупателя должно содержать от 4 до 50 символов")]
        public string PatronymicOfBuyer
        {
            get { return patronymicOfBuyer; }
            set { patronymicOfBuyer = value; }
        }

        [DisplayName("Buyer's yearOfBirth")]
        [Required(ErrorMessage = "Требуется год рождения покупателя")]
        [Range(1922, 2004, ErrorMessage = "Год рождения покупателя должен быть больше 1922 и меньше 2004")]
        public int YearOfBirthOfBuyer
        {
            get { return yearOfBirthOfBuyer; }
            set { yearOfBirthOfBuyer = value; }
        }

        [DisplayName("Buyer's PhoneOfOwner")]
        [Required(ErrorMessage = "Требуется номер телефона покупателя")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Номер телефона должен состоять из 11 цифр и начинаться с кода страны без \"+\"")]
        public string PhoneOfBuyer
        {
            get { return phoneOfBuyer; }
            set { phoneOfBuyer = value; }
        }

        [DisplayName("Buyer's passportSeriesOfOwner")]
        [Required(ErrorMessage = "Требуется серия паспорта покупателя")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Серия паспорта должна состоять из 4 цифр")]
        public string PassportSeriesOfBuyer
        {
            get { return passportSeriesOfBuyer; }
            set { passportSeriesOfBuyer = value; }
        }

        [DisplayName("Buyer's passportNumberOfOwner")]
        [Required(ErrorMessage = "Требуется номер паспорта покупателя")]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Номер паспорта должна состоять из 6 цифр")]
        public string PassportNumberOfBuyer
        {
            get { return passportNumberOfBuyer; }
            set { passportNumberOfBuyer = value; }
        }

        [DisplayName("Buyer's passportSubdivisionCodeOfOwner")]
        [Required(ErrorMessage = "Требуется код подразделения паспорта покупателя")]
        [RegularExpression(@"^[0-9]{3}[-]{1}[0-9]{3}$", ErrorMessage = "Код подразделения паспорта должна иметь вид: ___-___")]
        public string PassportSubdivisionCodeOfBuyer
        {
            get { return passportSubdivisionCodeOfBuyer; }
            set { passportSubdivisionCodeOfBuyer = value; }
        }
    }
}
