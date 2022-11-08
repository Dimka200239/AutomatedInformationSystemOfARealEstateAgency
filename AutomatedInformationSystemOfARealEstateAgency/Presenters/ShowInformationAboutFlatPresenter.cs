using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class ShowInformationAboutFlatPresenter
    {
        // Поля
        private IShowInformationAboutFlatView flatView;
        private IShowInformationAboutFlatRepository repository;
        private readonly string sqlConnectionString;
        private readonly List<string> informationAboutFlat;
        private readonly OwnerModel ownerModel;

        public ShowInformationAboutFlatPresenter(IShowInformationAboutFlatView view,
                                                 IShowInformationAboutFlatRepository repository,
                                                 string sqlConnectionString,
                                                 List<string> informationAboutFlat,
                                                 OwnerModel ownerModel)
        {
            this.flatView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.informationAboutFlat = informationAboutFlat;
            this.ownerModel = ownerModel;

            this.flatView.LoadInformationAboutFlatEvent += LoadInformationAboutFlat;

            // Показ представления
            this.flatView.Show();
        }

        private void LoadInformationAboutFlat(object sender, EventArgs e)
        {
            flatView.SetCityOfApartment = informationAboutFlat[1];
            flatView.SetAvenueOfApartment = informationAboutFlat[2];
            flatView.SetHouseOfApartment = informationAboutFlat[3];
            flatView.SetCountOfRoomsOfApartment = int.Parse(informationAboutFlat[4]);
            flatView.SetTotalAreaOfApartment = float.Parse(informationAboutFlat[5]);
            flatView.SetKitchenAreaOfApartment = float.Parse(informationAboutFlat[6]);
            flatView.SetPresenceOfABalconyOfApartment = informationAboutFlat[7];
            flatView.SetBathroomOfApartment = informationAboutFlat[8];
            flatView.SetFloorOfApartment = int.Parse(informationAboutFlat[9]);
            flatView.SetNumberOfApartment = int.Parse(informationAboutFlat[10]);
            flatView.SetBuiltYearOfApartment = int.Parse(informationAboutFlat[11]);
            flatView.SetRenovationYearOfApartment = int.Parse(informationAboutFlat[12]);
            flatView.SetAvailabilityOfParkingOfApartment = informationAboutFlat[13];
            flatView.SetDistanceFromMetroOfApartment = float.Parse(informationAboutFlat[14]);
            flatView.SetDistanceFromCenterOfApartment = float.Parse(informationAboutFlat[15]);
            flatView.SetLivingSpaceOfApartment = float.Parse(informationAboutFlat[16]);
            flatView.SetRoomTypeOfApartment = informationAboutFlat[17];
            flatView.SetWindowsExitOfApartment = informationAboutFlat[18];
            flatView.SetRepairTypeOfApartment = informationAboutFlat[19];
            flatView.SetNumberOfOwnersOfApartment = int.Parse(informationAboutFlat[20]);
            flatView.SetDescriptionOfApartment = informationAboutFlat[21];
            flatView.SetApartmentPrice = float.Parse(informationAboutFlat[22]);
            flatView.SetOwnerName = ownerModel.NameOfOwner;
            flatView.SetOwnerSerName = ownerModel.SerNameOfOwner;
            flatView.SetOwnerpatronymic = ownerModel.PatronymicOfOwner;
            flatView.SetOwnerPhone = ownerModel.PhoneOfOwner;
        }
    }
}
