using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    /// <summary>
    /// Класс, описывающий репозиторий для работы с окном авторизации пользователя
    /// </summary>
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        public EmployeeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

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
        public EmployeeModel GetByLoginAndPassWord(string login, string passWord)
        {
            var employee = new EmployeeModel();
            employee = null;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM Employees
                                            WHERE loginOfEmployee = @login AND passwordOfEmployee = @passWord
                                            ORDER BY idOfEmployee DESC";
                    command.Parameters.Add("@login", SqlDbType.NVarChar).Value = login;
                    command.Parameters.Add("@passWord", SqlDbType.NVarChar).Value = passWord;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employeeModel = new EmployeeModel();
                            employeeModel.IdOfEmployee = (Guid)reader[0];
                            employeeModel.NameOfEmployee = reader[1].ToString();
                            employeeModel.SerNameOfEmployee = reader[2].ToString();
                            employeeModel.PatronymicOfEmployee = reader[3].ToString();
                            employeeModel.YearOfBirthOfEmployee = (int)reader[4];
                            employeeModel.LoginOfEmployee = reader[5].ToString();
                            employeeModel.PasswordOfEmployee = reader[6].ToString();

                            employee = employeeModel;
                        }
                    }
                }

                connection.Close();
            }

            if (employee != null)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }
    }
}
