using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    /// <summary>
    /// Класс, описывающий презентер для работы с окном поискаа квартиры
    /// </summary>
    public class FlatPresenter
    {
        // Поля
        private IMainView mainView;
        private IFlatView flatView;
        private IFlatRepository repository;
        private readonly string sqlConnectionString;
        private readonly EmployeeModel employeeModel;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="mainView">Интерфейс главного представления</param>
        /// <param name="view">Интерфейс представления поиска квартиры</param>
        /// <param name="repository">Интерфейс репозитория поиска квартиры</param>
        /// <param name="sqlConnectionString">Строка подключения к БД</param>
        public FlatPresenter(IMainView mainView, IFlatView view, IFlatRepository repository, string sqlConnectionString, EmployeeModel employeeModel)
        {
            this.mainView = mainView;
            this.flatView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.employeeModel = employeeModel;

            // Подписка на методы обработчика событий для просмотра событий
            this.flatView.SearchFlatEvent += SearchFlat;
            this.flatView.ShowInfoAboutFlatEvent += ShowInfoAboutFlat;
            this.flatView.ArrangeApartmentEvent += ArrangeApartment;

            // Показ представления
            this.flatView.Show();
        }

        /// <summary>
        /// Метод для поиска квартиры по вводимому параметру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchFlat(object sender, EventArgs e)
        {
            var result = repository.GetAllFlatInformation(flatView.GetInputValue());

            flatView.SetEmployeeListBindingSourse(result);
        }

        /// <summary>
        /// Метод для просмотра информации о выбранной квартире
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowInfoAboutFlat(object sender, EventArgs e)
        {
            if (flatView.CheckInformationInDataGrid())
            {
                var resultFlat = flatView.GetSelectedRow();

                var resultOwner = this.repository.GetOwnerById(new Guid(resultFlat[23]));

                IShowInformationAboutFlatView newView = ShowInformationAboutFlatView.GetInstance();
                IShowInformationAboutFlatRepository newRepository = new ShowInformationAboutFlatRepository(sqlConnectionString);
                new ShowInformationAboutFlatPresenter(newView, newRepository, sqlConnectionString, resultFlat, resultOwner);
            }
        }

        private void ArrangeApartment(object sender, EventArgs e)
        {
            if (flatView.CheckInformationInDataGrid())
            {
                var resultFlat = flatView.GetSelectedRow();

                var resultOwner = this.repository.GetOwnerById(new Guid(resultFlat[23]));

                var date = DateTime.Now;

                var cash = Convert.ToString(int.Parse(resultFlat[22]) * 0.1);
                cash = cash.Replace(".", ",");

                IAddNewBuyerView newView = AddNewBuyerView.GetInstance();
                IAddNewBuyerRepository newRepository = new AddNewBuyerRepository(sqlConnectionString);
                var newPresenter = new AddNewBuyerPresenter(newView,
                                                            newRepository,
                                                            sqlConnectionString,
                                                            resultOwner.IdOfOwner,
                                                            new Guid(resultFlat[0]),
                                                            employeeModel.IdOfEmployee,
                                                            date.ToString(),
                                                            float.Parse(resultFlat[22]),
                                                            float.Parse(cash));
            }
        }
    }
}
