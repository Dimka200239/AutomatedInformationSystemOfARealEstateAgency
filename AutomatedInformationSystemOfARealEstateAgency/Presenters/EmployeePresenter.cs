using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    /// <summary>
    /// Класс, описывающий презентер для работы с окном авторизации
    /// </summary>
    public class EmployeePresenter
    {
        // Поля

        private IMainView mainView;
        private IEmployeeView userView;
        private IEmployeeRepository repository;
        private readonly string sqlConnectionString;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="mainView">Интерфейс главного представления</param>
        /// <param name="view">Интерфейс представления авторизации</param>
        /// <param name="repository">Интерфейс репозитория авторизации</param>
        /// <param name="sqlConnectionString">Строка подключения к БД</param>
        public EmployeePresenter(IMainView mainView, IEmployeeView view, IEmployeeRepository repository, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.userView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;

            // Подписка на методы обработчика событий для просмотра событий
            this.userView.SignInEvent += SignIn;

            // Показ представления
            this.userView.Show();
        }

        /// <summary>
        /// Метод авторизации сотрудника (проверка вводимых данных)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignIn(object sender, EventArgs e)
        {
            var result = repository.GetByLoginAndPassWord(userView.UserLogin, userView.UserPassword);

            if (result == null)
            {
                MessageBox.Show("Введенные вами данные не верны!");
            }
            else
            {
                this.userView.Hide();

                IMainMenuView view = MainMenuView.GetInstance((MainView)mainView);
                IMainMenuRepository repository = new MainMenuRepository(sqlConnectionString);
                new MainMenuPresenter(mainView, view, repository, sqlConnectionString);
            }
        }
    }
}
