using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс, реализующий репозиторий для работы с окном авторизации
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Метод для поиска сотрудника в БД и получения информации о нём из неё
        /// </summary>
        /// <param name="login">Введеный логин</param>
        /// <param name="passWord">Введеный пароль</param>
        /// <returns>
        ///          Если логин и пароль введены верно,
        ///          то метод вернёт всю информацию о сотруднике,
        ///          иначе вернет null
        /// </returns>
        EmployeeModel GetByLoginAndPassWord(string login, string passWord);
    }
}
