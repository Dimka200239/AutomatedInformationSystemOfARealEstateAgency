using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    public class AddNewBuyerRepository : BaseRepository, IAddNewBuyerRepository
    {
        public AddNewBuyerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddNewBuyerInDataBase(Guid id,
                                          string name,
                                          string serName,
                                          string patronymic,
                                          int yearOfBirth,
                                          string phone,
                                          string passportSeries,
                                          string passportNuber,
                                          string passportSubdivisionCode)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Buyers
                                            VALUES (@idBuyer, " +
                                                   "@nameBuyer, " +
                                                   "@serNameBuyer, " +
                                                   "@patronymicBuyer, " +
                                                   "@yearOfBirthBuyer, " +
                                                   "@phoneBuyer, " +
                                                   "@passportSeriesBuyer, " +
                                                   "@passportNuberBuyer, " +
                                                   "@passportSubdivisionCodeBuyer)";
                    command.Parameters.Add("@idBuyer", SqlDbType.UniqueIdentifier).Value = id;
                    command.Parameters.Add("@nameBuyer", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@serNameBuyer", SqlDbType.NVarChar).Value = serName;
                    command.Parameters.Add("@patronymicBuyer", SqlDbType.NVarChar).Value = patronymic;
                    command.Parameters.Add("@yearOfBirthBuyer", SqlDbType.Int).Value = yearOfBirth;
                    command.Parameters.Add("@phoneBuyer", SqlDbType.NVarChar).Value = phone;
                    command.Parameters.Add("@passportSeriesBuyer", SqlDbType.NVarChar).Value = passportSeries;
                    command.Parameters.Add("@passportNuberBuyer", SqlDbType.NVarChar).Value = passportNuber;
                    command.Parameters.Add("@passportSubdivisionCodeBuyer", SqlDbType.NVarChar).Value = passportSubdivisionCode;
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        public bool CheckInformationAboutBuyer(string passportSeriesOfBuyer,
                                               string passportNumberOfBuyer,
                                               string passportSubdivisionCodeOfBuyer)
        {
            var countOfNotes = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Buyers
                                            WHERE passportSeriesOfBuyer = @passportSeriesOfBuyer
	                                              AND passportNumberOfBuyer = @passportNumberOfBuyer
	                                              AND passportSubdivisionCodeOfBuyer = @passportSubdivisionCodeOfBuyer";
                    command.Parameters.Add("@passportSeriesOfBuyer", SqlDbType.NVarChar).Value = passportSeriesOfBuyer;
                    command.Parameters.Add("@passportNumberOfBuyer", SqlDbType.NVarChar).Value = passportNumberOfBuyer;
                    command.Parameters.Add("@passportSubdivisionCodeOfBuyer", SqlDbType.NVarChar).Value = passportSubdivisionCodeOfBuyer;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            countOfNotes++;
                        }
                    }

                    connection.Close();
                }
            }

            if (countOfNotes != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public Guid GetIdOfBuyer(string passportSeriesOfBuyer,
                                 string passportNumberOfBuyer,
                                 string passportSubdivisionCodeOfBuyer)
        {
            Guid BuyerId = Guid.NewGuid();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Buyers
                                            WHERE passportSeriesOfBuyer = @passportSeriesOfBuyer
	                                              AND passportNumberOfBuyer = @passportNumberOfBuyer
	                                              AND passportSubdivisionCodeOfBuyer = @passportSubdivisionCodeOfBuyer";
                    command.Parameters.Add("@passportSeriesOfBuyer", SqlDbType.NVarChar).Value = passportSeriesOfBuyer;
                    command.Parameters.Add("@passportNumberOfBuyer", SqlDbType.NVarChar).Value = passportNumberOfBuyer;
                    command.Parameters.Add("@passportSubdivisionCodeOfBuyer", SqlDbType.NVarChar).Value = passportSubdivisionCodeOfBuyer;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BuyerId = (Guid)reader[0];
                        }
                    }

                    connection.Close();
                }
            }

            return BuyerId;
        }

        public bool AddNewContract(Guid ownerId,
                                   Guid buyerId,
                                   Guid apartmentId,
                                   Guid employeeId, 
                                   string date,
                                   float price, 
                                   float cashFlow)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO ContractsForThePurchaseOfAnApartment
                                            VALUES (@ownerId, " +
                                                   "@buyerId, " +
                                                   "@apartmentId, " +
                                                   "@employeeId, " +
                                                   "@date, " +
                                                   "@price, " +
                                                   "@cashFlow)";
                    command.Parameters.Add("@ownerId", SqlDbType.UniqueIdentifier).Value = ownerId;
                    command.Parameters.Add("@buyerId", SqlDbType.UniqueIdentifier).Value = buyerId;
                    command.Parameters.Add("@apartmentId", SqlDbType.UniqueIdentifier).Value = apartmentId;
                    command.Parameters.Add("@employeeId", SqlDbType.UniqueIdentifier).Value = employeeId;
                    command.Parameters.Add("@date", SqlDbType.NVarChar).Value = date;
                    command.Parameters.Add("@price", SqlDbType.Float).Value = price;
                    command.Parameters.Add("@cashFlow", SqlDbType.Float).Value = cashFlow;
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        public bool TakApartmentOffTheMarket(Guid apartmentId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"UPDATE Apartments
                                            SET statusOfApartment = 'Продано'
                                            FROM Apartments
                                            WHERE idOfApartment = @apartmentId";
                    command.Parameters.Add("@apartmentId", SqlDbType.UniqueIdentifier).Value = apartmentId;
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }
    }
}
