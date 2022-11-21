using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private readonly EmployeeModel employeeModel;

        // Поля для закрыытия формы

        IFlatView flatView = null;
        IAddNewOwnerView addNewOwnerView = null;
        IShowAllContractsView contractsView = null;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="mainView">Интерфейс главного представления</param>
        /// <param name="view">Интерфейс представления "Главное меню программы"</param>
        /// <param name="repository">Интерфейс репозитория "Главное меню программы"</param>
        /// <param name="sqlConnectionString">Строка подключения к БД</param>
        public MainMenuPresenter(IMainView mainView, IMainMenuView view, IMainMenuRepository repository, string sqlConnectionString, EmployeeModel employeeModel)
        {
            this.mainView = mainView;
            this.mainMenuView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.employeeModel = employeeModel;

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
            CloseUnnecessaryWindows("noExit");

            IFlatView newView = FlatView.GetInstance((MainView)mainView);
            IFlatRepository repository = new FlatRepository(sqlConnectionString);
            new FlatPresenter(mainView, newView, repository, sqlConnectionString, employeeModel);

            flatView = newView;
        }

        /// <summary>
        /// Метод для открытия окна для добавления новой квартиры в БД
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNewFlat(object sender, EventArgs e)
        {
            CloseUnnecessaryWindows("noExit");

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
            CloseUnnecessaryWindows("noExit");

            IShowAllContractsView newView = ShowAllContractsView.GetInstance((MainView)mainView);
            IShowAllContractsRepository repository = new ShowAllContractsRepository(sqlConnectionString);
            new ShowAllContractsPresenter(mainView, newView, repository, sqlConnectionString);

            contractsView = newView;
        }

        /// <summary>
        /// Метод для выхода из учетной записи сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit(object sender, EventArgs e)
        {
            CloseUnnecessaryWindows("Exit");

            mainMenuView.Close();

            IEmployeeView view = EmployeeView.GetInstance((MainView)mainView);
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            new EmployeePresenter(mainView, view, repository, sqlConnectionString);
        }

        private void CloseUnnecessaryWindows(string typeOfClosing)
        {
            if (typeOfClosing != "Exit")
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "MainView" && Application.OpenForms[i].Name != "MainMenuView")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
            else
            {
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "MainView")
                    {
                        Application.OpenForms[i].Close();
                    }
                }
            }
        }
    }
}
