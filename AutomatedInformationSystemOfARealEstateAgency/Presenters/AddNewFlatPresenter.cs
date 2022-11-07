using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class AddNewFlatPresenter
    {
        // Поля

        private IMainView mainView;
        private IAddNewFlatView addNewFlatView;
        private IAddNewFlatRepository repository;
        private readonly string sqlConnectionString;
        private readonly Guid guidOwner;

        public AddNewFlatPresenter(IMainView mainView, IAddNewFlatView view, IAddNewFlatRepository repository, string sqlConnectionString, Guid guidOwner)
        {
            this.mainView = mainView;
            this.addNewFlatView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.guidOwner = guidOwner;

            // Подписка на методы обработчика событий для просмотра событий
            addNewFlatView.AddNewFlatEvent += AddNewFlat;

            // Показ представления
            this.addNewFlatView.Show();
        }

        private void AddNewFlat(object sender, EventArgs e)
        {
            if (this.repository.CheckInformationAboutFlat(addNewFlatView.GetCityOfApartment,
                                                          addNewFlatView.GetAvenueOfApartment,
                                                          addNewFlatView.GetHouseOfApartment,
                                                          addNewFlatView.GetFloorOfApartment,
                                                          addNewFlatView.GetNumberOfApartment,
                                                          "В продаже") == false)
            {
                addNewFlatView.ShowInformation("Данная квартира уже продаётся.");
            }
            else
            {
                var newIdFlat = Guid.NewGuid();

                this.repository.AddNewFlatInDataBase(newIdFlat,
                                                     addNewFlatView.GetCityOfApartment,
                                                     addNewFlatView.GetAvenueOfApartment,
                                                     addNewFlatView.GetHouseOfApartment,
                                                     addNewFlatView.GetCountOfRoomsOfApartment,
                                                     addNewFlatView.GetTotalAreaOfApartment,
                                                     addNewFlatView.GetKitchenAreaOfApartment,
                                                     addNewFlatView.GetPresenceOfABalconyOfApartment,
                                                     addNewFlatView.GetBathroomOfApartment,
                                                     addNewFlatView.GetFloorOfApartment,
                                                     addNewFlatView.GetNumberOfApartment,
                                                     addNewFlatView.GetBuiltYearOfApartment,
                                                     addNewFlatView.GetRenovationYearOfApartment,
                                                     addNewFlatView.GetAvailabilityOfParkingOfApartment,
                                                     addNewFlatView.GetDistanceFromMetroOfApartment,
                                                     addNewFlatView.GetDistanceFromCenterOfApartment,
                                                     addNewFlatView.GetLivingSpaceOfApartment,
                                                     addNewFlatView.GetRoomTypeOfApartment,
                                                     addNewFlatView.GetWindowsExitOfApartment,
                                                     addNewFlatView.GetRepairTypeOfApartment,
                                                     addNewFlatView.GetNumberOfOwnersOfApartment,
                                                     addNewFlatView.GetDescriptionOfApartment,
                                                     addNewFlatView.GetApartmentPrice,
                                                     this.guidOwner,
                                                     "В продаже");

                addNewFlatView.ShowInformation("Квартира успешно добавлена в базу данных и выставлена на продажу!");
            }

            this.addNewFlatView.Close();
        }
    }
}
