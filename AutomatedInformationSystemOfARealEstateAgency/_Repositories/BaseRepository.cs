using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    /// <summary>
    /// Класс, описывающий базовый репозиторий
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        /// Наследуемое поле, которое хранит в себе строку подключения к БД
        /// </summary>
        protected string connectionString;
    }
}
