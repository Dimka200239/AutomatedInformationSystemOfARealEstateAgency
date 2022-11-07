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
        int GetCountOfRoomsOfApartment { get; set; }
        float GetTotalAreaOfApartment { get; set; }
        float GetKitchenAreaOfApartment { get; set; }
        string GetPresenceOfABalconyOfApartment { get; set; }
        string GetBathroomOfApartment { get; set; }
        int GetFloorOfApartment { get; set; }
        int GetNumberOfApartment { get; set; }
        int GetBuiltYearOfApartment { get; set; }
        int GetRenovationYearOfApartment { get; set; }
        string GetAvailabilityOfParkingOfApartment { get; set; }
        float GetDistanceFromMetroOfApartment { get; set; }
        float GetDistanceFromCenterOfApartment { get; set; }
        float GetLivingSpaceOfApartment { get; set; }
        string GetRoomTypeOfApartment { get; set; }
        string GetWindowsExitOfApartment { get; set; }
        string GetRepairTypeOfApartment { get; set; }
        int GetNumberOfOwnersOfApartment { get; set; }
        string GetDescriptionOfApartment { get; set; }
        float GetApartmentPrice { get; set; }

        event EventHandler AddNewFlatEvent;
    }
}
