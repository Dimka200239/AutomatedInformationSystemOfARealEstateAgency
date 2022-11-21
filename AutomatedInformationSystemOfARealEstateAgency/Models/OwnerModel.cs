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
        [Required(ErrorMessage = "Требуется имя владельца")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Имя владельца должно содержать от 3 до 50 символов")]
        public string NameOfOwner
        {
            get { return nameOfOwner; }
            set { nameOfOwner = value; }
        }

        [DisplayName("Owner's serName")]
        [Required(ErrorMessage = "Требуется фамилия владельца")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Фамилия владельца должно содержать от 4 до 50 символов")]
        public string SerNameOfOwner
        {
            get { return serNameOfOwner; }
            set { serNameOfOwner = value; }
        }

        [DisplayName("Owner's patronymic")]
        [Required(ErrorMessage = "Требуется отчество владельца")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Отчество владельца должно содержать от 4 до 50 символов")]
        public string PatronymicOfOwner
        {
            get { return patronymicOfOwner; }
            set { patronymicOfOwner = value; }
        }

        [DisplayName("Owner's yearOfBirth")]
        [Required(ErrorMessage = "Требуется год рождения владельца")]
        [Range(1922, 2004, ErrorMessage = "Год рождения владельца должен быть больше 1922 и меньше 2004")]
        public int YearOfBirthOfOwner
        {
            get { return yearOfBirthOfOwner; }
            set { yearOfBirthOfOwner = value; }
        }

        [DisplayName("Owner's PhoneOfOwner")]
        [Required(ErrorMessage = "Требуется номер телефона владельца")]
        [RegularExpression(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$", ErrorMessage = "Номер телефона должен состоять из 11 цифр и начинаться с кода страны без \"+\"")]
        public string PhoneOfOwner
        {
            get { return phoneOfOwner; }
            set { phoneOfOwner = value; }
        }

        [DisplayName("Owner's passportSeriesOfOwner")]
        [Required(ErrorMessage = "Требуется серия паспорта владельца")]
        [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "Серия паспорта должна состоять из 4 цифр")]
        public string PassportSeriesOfOwner
        {
            get { return passportSeriesOfOwner; }
            set { passportSeriesOfOwner = value; }
        }

        [DisplayName("Owner's passportNumberOfOwner")]
        [Required(ErrorMessage = "Требуется номер паспорта владельца")]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Номер паспорта должна состоять из 6 цифр")]
        public string PassportNumberOfOwner
        {
            get { return passportNumberOfOwner; }
            set { passportNumberOfOwner = value; }
        }

        [DisplayName("Owner's passportSubdivisionCodeOfOwner")]
        [Required(ErrorMessage = "Требуется код подразделения паспорта владельца")]
        [RegularExpression(@"^[0-9]{3}[-]{1}[0-9]{3}$", ErrorMessage = "Код подразделения паспорта должна иметь вид: ___-___")]
        public string PassportSubdivisionCodeOfOwner
        {
            get { return passportSubdivisionCodeOfOwner; }
            set { passportSubdivisionCodeOfOwner = value; }
        }
    }
}
