using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IAddNewFlatView
    {
        void Show();
        void Hide();
        void Close();

        void ShowInformation(string message);

        void SetSettingForComboBox();

        string GetCityOfApartment { get; set; }
        string GetAvenueOfApartment { get; set; }
        string GetHouseOfApartment { get; set; }
        string GetCountOfRoomsOfApartment { get; set; }
        string GetTotalAreaOfApartment { get; set; }
        string GetKitchenAreaOfApartment { get; set; }
        string GetPresenceOfABalconyOfApartment { get; set; }
        string GetBathroomOfApartment { get; set; }
        string GetFloorOfApartment { get; set; }
        string GetNumberOfApartment { get; set; }
        string GetBuiltYearOfApartment { get; set; }
        string GetRenovationYearOfApartment { get; set; }
        string GetAvailabilityOfParkingOfApartment { get; set; }
        string GetDistanceFromMetroOfApartment { get; set; }
        string GetDistanceFromCenterOfApartment { get; set; }
        string GetLivingSpaceOfApartment { get; set; }
        string GetRoomTypeOfApartment { get; set; }
        string GetWindowsExitOfApartment { get; set; }
        string GetRepairTypeOfApartment { get; set; }
        string GetNumberOfOwnersOfApartment { get; set; }
        string GetDescriptionOfApartment { get; set; }
        string GetApartmentPrice { get; set; }

        event EventHandler AddNewFlatEvent;
    }
}
