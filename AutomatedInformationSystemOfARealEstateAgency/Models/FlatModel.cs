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
    /// Класс, описывающий сущность - квартира
    /// </summary>
    public class FlatModel
    {
        // Поля класса

        private Guid idOfApartment;
        private string cityOfApartment;
        private string avenueOfApartment;
        private string houseOfApartment;
        private int countOfRoomsOfApartment;
        private float totalAreaOfApartment;
        private float kitchenAreaOfApartment;
        private string presenceOfABalconyOfApartment;
        private string bathroomOfApartment;
        private int floorOfApartment;
        private int numberOfApartment;
        private int builtYearOfApartment;
        private int renovationYearOfApartment;
        private string availabilityOfParkingOfApartment;
        private float distanceFromMetroOfApartment;
        private float distanceFromCenterOfApartment;
        private float livingSpaceOfApartment;
        private string roomTypeOfApartment;
        private string windowsExitOfApartment;
        private string repairTypeOfApartment;
        private int numberOfOwnersOfApartment;
        private string descriptionOfApartment;
        private float apartmentPrice;
        private Guid apartmentOwner;
        private string statusOfApartment;

        // Свойства - Валидатор

        [DisplayName("Айди квартиры")]
        public Guid IdOfApartment
        {
            get { return idOfApartment; }
            set { idOfApartment = value; }
        }

        [DisplayName("Город")]
        [Required(ErrorMessage = "Требуется название города")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Название города должно содержать от 3 до 50 символов")]
        public string CityOfApartment
        {
            get { return cityOfApartment; }
            set { cityOfApartment = value; }
        }

        [DisplayName("Улица")]
        [Required(ErrorMessage = "Требуется название улицы")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Название улицы должно содержать от 4 до 50 символов")]
        public string AvenueOfApartment
        {
            get { return avenueOfApartment; }
            set { avenueOfApartment = value; }
        }

        [DisplayName("Номер дома")]
        [Required(ErrorMessage = "Требуется номер дома")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Номер дома должен содержать хотя бы 1 символ")]
        public string HouseOfApartment
        {
            get { return houseOfApartment; }
            set { houseOfApartment = value; }
        }

        [DisplayName("Кол-во комнат")]
        [Required(ErrorMessage = "Требуется кол-во команат")]
        [Range(1, 10, ErrorMessage = "Кол-во команат должно быть больше 0 и меньше 10")]
        public int CountOfRoomsOfApartment
        {
            get { return countOfRoomsOfApartment; }
            set { countOfRoomsOfApartment = value; }
        }

        [DisplayName("Общая площадь")]
        [Required(ErrorMessage = "Требуется общая площадь")]
        [Range(1, 1000, ErrorMessage = "Общая площадь должна быть больше 0 и меньше 1000")]
        public float TotalAreaOfApartment
        {
            get { return totalAreaOfApartment; }
            set { totalAreaOfApartment = value; }
        }

        [DisplayName("Площадь кухни")]
        [Required(ErrorMessage = "Требуется площадь кухни")]
        [Range(1, 1000, ErrorMessage = "Площадь кухни должна быть больше 0 и меньше 1000")]
        public float KitchenAreaOfApartment
        {
            get { return kitchenAreaOfApartment; }
            set { kitchenAreaOfApartment = value; }
        }

        [DisplayName("Наличие балкона")]
        [Required(ErrorMessage = "Требуется наличие балкона")]
        public string PresenceOfABalconyOfApartment
        {
            get { return presenceOfABalconyOfApartment; }
            set { presenceOfABalconyOfApartment = value; }
        }

        [DisplayName("Тип санузла")]
        [Required(ErrorMessage = "Требуется тип санузла")]
        public string BathroomOfApartment
        {
            get { return bathroomOfApartment; }
            set { bathroomOfApartment = value; }
        }

        [DisplayName("Этаж")]
        [Required(ErrorMessage = "Требуется этаж")]
        [Range(1, 1000, ErrorMessage = "Этаж должен быть больше 0")]
        public int FloorOfApartment
        {
            get { return floorOfApartment; }
            set { floorOfApartment = value; }
        }

        [DisplayName("Номер квартиры")]
        [Required(ErrorMessage = "Требуется номер квартиры")]
        [Range(1, 1000, ErrorMessage = "Номер квартиры должен быть больше 0")]
        public int NumberOfApartment
        {
            get { return numberOfApartment; }
            set { numberOfApartment = value; }
        }

        [DisplayName("Год постройки")]
        [Required(ErrorMessage = "Требуется год постройки дома")]
        [Range(1922, 2022, ErrorMessage = "Год постройки дома должен быть больше 1922 и меньше 2022")]
        public int BuiltYearOfApartment
        {
            get { return builtYearOfApartment; }
            set { builtYearOfApartment = value; }
        }

        [DisplayName("Год ремонта")]
        [Required(ErrorMessage = "Требуется год последнего ремонта")]
        [Range(1922, 2022, ErrorMessage = "Год последнего ремонта должен быть больше 1922 и меньше 2022")]
        public int RenovationYearOfApartment
        {
            get { return renovationYearOfApartment; }
            set { renovationYearOfApartment = value; }
        }

        [DisplayName("Тип парковки")]
        [Required(ErrorMessage = "Требуется тип парковки")]
        public string AvailabilityOfParkingOfApartment
        {
            get { return availabilityOfParkingOfApartment; }
            set { availabilityOfParkingOfApartment = value; }
        }

        [DisplayName("Расстояние до метро")]
        [Required(ErrorMessage = "Требуется расстояние до метро")]
        [Range(0.0001, 1000, ErrorMessage = "Расстояние до метро должно быть больше 0")]
        public float DistanceFromMetroOfApartment
        {
            get { return distanceFromMetroOfApartment; }
            set { distanceFromMetroOfApartment = value; }
        }

        [DisplayName("Расстояние до центра")]
        [Required(ErrorMessage = "Требуется расстояние до центра")]
        [Range(0.0001, 1000, ErrorMessage = "Расстояние до центра должно быть больше 0")]
        public float DistanceFromCenterOfApartment
        {
            get { return distanceFromCenterOfApartment; }
            set { distanceFromCenterOfApartment = value; }
        }

        [DisplayName("Жилая площадь")]
        [Required(ErrorMessage = "Требуется жилая площадь")]
        [Range(1, 1000, ErrorMessage = "Жилая площадь должна быть больше 0")]
        public float LivingSpaceOfApartment
        {
            get { return livingSpaceOfApartment; }
            set { livingSpaceOfApartment = value; }
        }

        [DisplayName("Тип комнат")]
        [Required(ErrorMessage = "Требуется тип комнат")]
        public string RoomTypeOfApartment
        {
            get { return roomTypeOfApartment; }
            set { roomTypeOfApartment = value; }
        }

        [DisplayName("Тип окон")]
        [Required(ErrorMessage = "Требуется тип окон")]
        public string WindowsExitOfApartment
        {
            get { return windowsExitOfApartment; }
            set { windowsExitOfApartment = value; }
        }

        [DisplayName("Тип ремонта")]
        [Required(ErrorMessage = "Требуется тип ремонта")]
        public string RepairTypeOfApartment
        {
            get { return repairTypeOfApartment; }
            set { repairTypeOfApartment = value; }
        }

        [DisplayName("Кол-во собственников")]
        [Required(ErrorMessage = "Требуется кол-во собственников")]
        [Range(1, 1000, ErrorMessage = "Кол-во собственников должно быть больше 0")]
        public int NumberOfOwnersOfApartment
        {
            get { return numberOfOwnersOfApartment; }
            set { numberOfOwnersOfApartment = value; }
        }

        [DisplayName("Описание")]
        public string DescriptionOfApartment
        {
            get { return descriptionOfApartment; }
            set { descriptionOfApartment = value; }
        }

        [DisplayName("Цена")]
        [Required(ErrorMessage = "Требуется цена продажи")]
        [Range(1, 10000000, ErrorMessage = "Цена продажи должна быть больше 0 и меньше 10 млн рублей")]
        public float ApartmentPrice
        {
            get { return apartmentPrice; }
            set { apartmentPrice = value; }
        }

        [DisplayName("Айди владельца")]
        public Guid ApartmentOwner
        {
            get { return apartmentOwner; }
            set { apartmentOwner = value; }
        }

        [DisplayName("Статус")]
        public string StatusOfApartment
        {
            get { return statusOfApartment; }
            set { statusOfApartment = value; }
        }
    }
}
