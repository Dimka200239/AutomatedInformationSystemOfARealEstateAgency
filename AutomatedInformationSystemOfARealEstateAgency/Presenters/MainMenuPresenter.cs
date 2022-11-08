using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    /// <summary>
    /// Класс, описывающий презентер для работы с окном главного меню программы
    /// </summary>
    public class MainMenuPresenter
    {
        // Поля

        private IMainView mainView;
        private IMainMenuView mainMenuView;
        private IMainMenuRepository repository;
        private readonly string sqlConnectionString;

        // Поля для закрыытия формы

        IFlatView flatView = null;
        IAddNewOwnerView addNewOwnerView = null;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="mainView">Интерфейс главного представления</param>
        /// <param name="view">Интерфейс представления "Главное меню программы"</param>
        /// <param name="repository">Интерфейс репозитория "Главное меню программы"</param>
        /// <param name="sqlConnectionString">Строка подключения к БД</param>
        public MainMenuPresenter(IMainView mainView, IMainMenuView view, IMainMenuRepository repository, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.mainMenuView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;

            // Подписка на методы обработчика событий для просмотра событий
            mainMenuView.ShowAllFlatsEvent += ShowAllFlats;
            mainMenuView.AddNewFlatEvent += AddNewFlat;
            mainMenuView.ShowShoppingStoreEvent += ShowShoppingStore;
            mainMenuView.ExitEvent += Exit;

            // Показ представления
            this.mainMenuView.Show();
        }

        /// <summary>
        /// Метод для открытия окна для поиска квартиры по вводимому параметру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAllFlats(object sender, EventArgs e)
        {
            if (addNewOwnerView != null) { addNewOwnerView.Close(); }

            IFlatView newView = FlatView.GetInstance((MainView)mainView);
            IFlatRepository repository = new FlatRepository(sqlConnectionString);
            new FlatPresenter(mainView, newView, repository, sqlConnectionString);

            flatView = newView;
        }

        /// <summary>
        /// Метод для открытия окна для добавления новой квартиры в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewFlat(object sender, EventArgs e)
        {
            if (flatView != null) { flatView.Close(); }

            IAddNewOwnerView newView = AddNewOwnerView.GetInstance((MainView)mainView);
            IAddNewOwnerRepository repository = new AddNewOwnerRepository(sqlConnectionString);
            new AddNewOwnerPresenter(mainView, newView, repository, sqlConnectionString);

            addNewOwnerView = newView;
        }

        /// <summary>
        /// Метод для открытия окна для просмотра всех договоров
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowShoppingStore(object sender, EventArgs e)
        {
            if (flatView != null) { flatView.Close(); }
            if (addNewOwnerView != null) { addNewOwnerView.Close(); }
        }

        /// <summary>
        /// Метод для выхода из учетной записи сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            if (flatView != null) { flatView.Close(); }
            if (addNewOwnerView != null) { addNewOwnerView.Close(); }
        }
    }
}
