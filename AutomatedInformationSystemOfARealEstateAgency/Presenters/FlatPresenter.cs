﻿using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
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

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="mainView">Интерфейс главного представления</param>
        /// <param name="view">Интерфейс представления поиска квартиры</param>
        /// <param name="repository">Интерфейс репозитория поиска квартиры</param>
        /// <param name="sqlConnectionString">Строка подключения к БД</param>
        public FlatPresenter(IMainView mainView, IFlatView view, IFlatRepository repository, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.flatView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;

            // Подписка на методы обработчика событий для просмотра событий
            this.flatView.SearchFlatEvent += SearchFlat;
            this.flatView.ShowInfoAboutFlatEvent += ShowInfoAboutFlat;

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

            }
        }
    }
}
