using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    /// <summary>
    /// Класс, описывающий репозиторий для работы с окном главного меню программы
    /// </summary>
    public class MainMenuRepository : BaseRepository, IMainMenuRepository
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        public MainMenuRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
