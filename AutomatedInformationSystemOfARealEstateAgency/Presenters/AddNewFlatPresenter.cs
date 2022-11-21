using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomatedInformationSystemOfARealEstateAgency.Views;

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
            try
            {
                var model = new FlatModel();
                model.CityOfApartment = addNewFlatView.GetCityOfApartment;
                model.AvenueOfApartment = addNewFlatView.GetAvenueOfApartment;
                model.HouseOfApartment = addNewFlatView.GetHouseOfApartment;
                model.CountOfRoomsOfApartment = int.Parse(addNewFlatView.GetCountOfRoomsOfApartment);
                model.TotalAreaOfApartment = float.Parse(addNewFlatView.GetTotalAreaOfApartment);
                model.KitchenAreaOfApartment = float.Parse(addNewFlatView.GetKitchenAreaOfApartment);
                model.PresenceOfABalconyOfApartment = addNewFlatView.GetPresenceOfABalconyOfApartment;
                model.BathroomOfApartment = addNewFlatView.GetBathroomOfApartment;
                model.FloorOfApartment = int.Parse(addNewFlatView.GetFloorOfApartment);
                model.NumberOfApartment = int.Parse(addNewFlatView.GetNumberOfApartment);
                model.BuiltYearOfApartment = int.Parse(addNewFlatView.GetBuiltYearOfApartment);
                model.RenovationYearOfApartment = int.Parse(addNewFlatView.GetRenovationYearOfApartment);
                model.AvailabilityOfParkingOfApartment = addNewFlatView.GetAvailabilityOfParkingOfApartment;
                model.DistanceFromMetroOfApartment = float.Parse(addNewFlatView.GetDistanceFromMetroOfApartment);
                model.DistanceFromCenterOfApartment = float.Parse(addNewFlatView.GetDistanceFromCenterOfApartment);
                model.LivingSpaceOfApartment = float.Parse(addNewFlatView.GetLivingSpaceOfApartment);
                model.RoomTypeOfApartment = addNewFlatView.GetRoomTypeOfApartment;
                model.WindowsExitOfApartment = addNewFlatView.GetWindowsExitOfApartment;
                model.RepairTypeOfApartment = addNewFlatView.GetRepairTypeOfApartment;
                model.NumberOfOwnersOfApartment = int.Parse(addNewFlatView.GetNumberOfOwnersOfApartment);
                model.DescriptionOfApartment = addNewFlatView.GetDescriptionOfApartment;
                model.ApartmentPrice = float.Parse(addNewFlatView.GetApartmentPrice);

                new Common.ModelDataValidation().Validate(model);

                if (this.repository.CheckInformationAboutFlat(addNewFlatView.GetCityOfApartment,
                                                          addNewFlatView.GetAvenueOfApartment,
                                                          addNewFlatView.GetHouseOfApartment,
                                                          int.Parse(addNewFlatView.GetFloorOfApartment),
                                                          int.Parse(addNewFlatView.GetNumberOfApartment),
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
                                                         int.Parse(addNewFlatView.GetCountOfRoomsOfApartment),
                                                         float.Parse(addNewFlatView.GetTotalAreaOfApartment),
                                                         int.Parse(addNewFlatView.GetKitchenAreaOfApartment),
                                                         addNewFlatView.GetPresenceOfABalconyOfApartment,
                                                         addNewFlatView.GetBathroomOfApartment,
                                                         int.Parse(addNewFlatView.GetFloorOfApartment),
                                                         int.Parse(addNewFlatView.GetNumberOfApartment),
                                                         int.Parse(addNewFlatView.GetBuiltYearOfApartment),
                                                         int.Parse(addNewFlatView.GetRenovationYearOfApartment),
                                                         addNewFlatView.GetAvailabilityOfParkingOfApartment,
                                                         float.Parse(addNewFlatView.GetDistanceFromMetroOfApartment),
                                                         float.Parse(addNewFlatView.GetDistanceFromCenterOfApartment),
                                                         float.Parse(addNewFlatView.GetLivingSpaceOfApartment),
                                                         addNewFlatView.GetRoomTypeOfApartment,
                                                         addNewFlatView.GetWindowsExitOfApartment,
                                                         addNewFlatView.GetRepairTypeOfApartment,
                                                         int.Parse(addNewFlatView.GetNumberOfOwnersOfApartment),
                                                         addNewFlatView.GetDescriptionOfApartment,
                                                         float.Parse(addNewFlatView.GetApartmentPrice),
                                                         this.guidOwner,
                                                         "В продаже");

                    addNewFlatView.ShowInformation("Квартира успешно добавлена в базу данных и выставлена на продажу!");
                }

                this.addNewFlatView.Close();
            }
            catch (Exception ex)
            {
                addNewFlatView.ShowInformation(ex.Message);
            }
        }
    }
}
