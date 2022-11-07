using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Flat's IdOfApartment")]
        public Guid IdOfApartment
        {
            get { return idOfApartment; }
            set { idOfApartment = value; }
        }

        [DisplayName("Flat's cityOfApartment")]
        public string CityOfApartment
        {
            get { return cityOfApartment; }
            set { cityOfApartment = value; }
        }

        [DisplayName("Flat's AvenueOfApartment")]
        public string AvenueOfApartment
        {
            get { return avenueOfApartment; }
            set { avenueOfApartment = value; }
        }

        [DisplayName("Flat's HouseOfApartment")]
        public string HouseOfApartment
        {
            get { return houseOfApartment; }
            set { houseOfApartment = value; }
        }

        [DisplayName("Flat's CountOfRoomsOfApartment")]
        public int CountOfRoomsOfApartment
        {
            get { return countOfRoomsOfApartment; }
            set { countOfRoomsOfApartment = value; }
        }

        [DisplayName("Flat's TotalAreaOfApartment")]
        public float TotalAreaOfApartment
        {
            get { return totalAreaOfApartment; }
            set { totalAreaOfApartment = value; }
        }

        [DisplayName("Flat's KitchenAreaOfApartment")]
        public float KitchenAreaOfApartment
        {
            get { return kitchenAreaOfApartment; }
            set { kitchenAreaOfApartment = value; }
        }

        [DisplayName("Flat's PresenceOfABalconyOfApartment")]
        public string PresenceOfABalconyOfApartment
        {
            get { return presenceOfABalconyOfApartment; }
            set { presenceOfABalconyOfApartment = value; }
        }

        [DisplayName("Flat's BathroomOfApartment")]
        public string BathroomOfApartment
        {
            get { return bathroomOfApartment; }
            set { bathroomOfApartment = value; }
        }

        [DisplayName("Flat's FloorOfApartment")]
        public int FloorOfApartment
        {
            get { return floorOfApartment; }
            set { floorOfApartment = value; }
        }

        [DisplayName("Flat's NumberOfApartment")]
        public int NumberOfApartment
        {
            get { return numberOfApartment; }
            set { numberOfApartment = value; }
        }

        [DisplayName("Flat's BuiltYearOfApartment")]
        public int BuiltYearOfApartment
        {
            get { return builtYearOfApartment; }
            set { builtYearOfApartment = value; }
        }

        [DisplayName("Flat's RenovationYearOfApartment")]
        public int RenovationYearOfApartment
        {
            get { return renovationYearOfApartment; }
            set { renovationYearOfApartment = value; }
        }

        [DisplayName("Flat's AvailabilityOfParkingOfApartment")]
        public string AvailabilityOfParkingOfApartment
        {
            get { return availabilityOfParkingOfApartment; }
            set { availabilityOfParkingOfApartment = value; }
        }

        [DisplayName("Flat's DistanceFromMetroOfApartment")]
        public float DistanceFromMetroOfApartment
        {
            get { return distanceFromMetroOfApartment; }
            set { distanceFromMetroOfApartment = value; }
        }

        [DisplayName("Flat's DistanceFromCenterOfApartment")]
        public float DistanceFromCenterOfApartment
        {
            get { return distanceFromCenterOfApartment; }
            set { distanceFromCenterOfApartment = value; }
        }

        [DisplayName("Flat's LivingSpaceOfApartment")]
        public float LivingSpaceOfApartment
        {
            get { return livingSpaceOfApartment; }
            set { livingSpaceOfApartment = value; }
        }

        [DisplayName("Flat's RoomTypeOfApartment")]
        public string RoomTypeOfApartment
        {
            get { return roomTypeOfApartment; }
            set { roomTypeOfApartment = value; }
        }

        [DisplayName("Flat's WindowsExitOfApartment")]
        public string WindowsExitOfApartment
        {
            get { return windowsExitOfApartment; }
            set { windowsExitOfApartment = value; }
        }

        [DisplayName("Flat's RepairTypeOfApartment")]
        public string RepairTypeOfApartment
        {
            get { return repairTypeOfApartment; }
            set { repairTypeOfApartment = value; }
        }

        [DisplayName("Flat's NumberOfOwnersOfApartment")]
        public int NumberOfOwnersOfApartment
        {
            get { return numberOfOwnersOfApartment; }
            set { numberOfOwnersOfApartment = value; }
        }

        [DisplayName("Flat's DescriptionOfApartment")]
        public string DescriptionOfApartment
        {
            get { return descriptionOfApartment; }
            set { descriptionOfApartment = value; }
        }

        [DisplayName("Flat's ApartmentPrice")]
        public float ApartmentPrice
        {
            get { return apartmentPrice; }
            set { apartmentPrice = value; }
        }

        [DisplayName("Flat's ApartmentOwner")]
        public Guid ApartmentOwner
        {
            get { return apartmentOwner; }
            set { apartmentOwner = value; }
        }

        [DisplayName("Flat's StatusOfApartment")]
        public string StatusOfApartment
        {
            get { return statusOfApartment; }
            set { statusOfApartment = value; }
        }
    }
}
