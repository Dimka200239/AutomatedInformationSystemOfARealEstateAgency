using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IShowInformationAboutFlatView
    {
        void Show();
        void Hide();
        void Close();

        // Свойста для квартиры
        string SetCityOfApartment { get; set; }
        string SetAvenueOfApartment { get; set; }
        string SetHouseOfApartment { get; set; }
        int SetCountOfRoomsOfApartment { get; set; }
        float SetTotalAreaOfApartment { get; set; }
        float SetKitchenAreaOfApartment { get; set; }
        string SetPresenceOfABalconyOfApartment { get; set; }
        string SetBathroomOfApartment { get; set; }
        int SetFloorOfApartment { get; set; }
        int SetNumberOfApartment { get; set; }
        int SetBuiltYearOfApartment { get; set; }
        int SetRenovationYearOfApartment { get; set; }
        string SetAvailabilityOfParkingOfApartment { get; set; }
        float SetDistanceFromMetroOfApartment { get; set; }
        float SetDistanceFromCenterOfApartment { get; set; }
        float SetLivingSpaceOfApartment { get; set; }
        string SetRoomTypeOfApartment { get; set; }
        string SetWindowsExitOfApartment { get; set; }
        string SetRepairTypeOfApartment { get; set; }
        int SetNumberOfOwnersOfApartment { get; set; }
        string SetDescriptionOfApartment { get; set; }
        float SetApartmentPrice { get; set; }

        // Свойста для владельца
        string SetOwnerName { get; set; }
        string SetOwnerSerName { get; set; }
        string SetOwnerpatronymic { get; set; }
        string SetOwnerPhone { get; set; }

        event EventHandler LoadInformationAboutFlatEvent;
    }
}
