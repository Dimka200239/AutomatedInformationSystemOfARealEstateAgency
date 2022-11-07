using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    public class AddNewOwnerRepository : BaseRepository, IAddNewOwnerRepository
    {
        public AddNewOwnerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddNewOwnerInDataBase(Guid id,
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
                    command.CommandText = @"INSERT INTO Owners
                                            VALUES (@idOwner, " +
                                                   "@nameOwner, " +
                                                   "@serNameOwner, " +
                                                   "@patronymicOwner, " +
                                                   "@yearOfBirthOwner, " +
                                                   "@phoneOwner, " +
                                                   "@passportSeriesOwner, " +
                                                   "@passportNuberOwner, " +
                                                   "@passportSubdivisionCodeOwner)";
                    command.Parameters.Add("@idOwner", SqlDbType.UniqueIdentifier).Value = id;
                    command.Parameters.Add("@nameOwner", SqlDbType.NVarChar).Value = name;
                    command.Parameters.Add("@serNameOwner", SqlDbType.NVarChar).Value = serName;
                    command.Parameters.Add("@patronymicOwner", SqlDbType.NVarChar).Value = patronymic;
                    command.Parameters.Add("@yearOfBirthOwner", SqlDbType.Int).Value = yearOfBirth;
                    command.Parameters.Add("@phoneOwner", SqlDbType.NVarChar).Value = phone;
                    command.Parameters.Add("@passportSeriesOwner", SqlDbType.NVarChar).Value = passportSeries;
                    command.Parameters.Add("@passportNuberOwner", SqlDbType.NVarChar).Value = passportNuber;
                    command.Parameters.Add("@passportSubdivisionCodeOwner", SqlDbType.NVarChar).Value = passportSubdivisionCode;
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        public bool CheckInformationAboutOwner(string passportSeriesOfOwner,
                                               string passportNumberOfOwner,
                                               string passportSubdivisionCodeOfOwner)
        {
            var countOfNotes = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Owners
                                            WHERE passportSeriesOfOwner = @passportSeriesOfOwner
	                                              AND passportNumberOfOwner = @passportNumberOfOwner
	                                              AND passportSubdivisionCodeOfOwner = @passportSubdivisionCodeOfOwner";
                    command.Parameters.Add("@passportSeriesOfOwner", SqlDbType.NVarChar).Value = passportSeriesOfOwner;
                    command.Parameters.Add("@passportNumberOfOwner", SqlDbType.NVarChar).Value = passportNumberOfOwner;
                    command.Parameters.Add("@passportSubdivisionCodeOfOwner", SqlDbType.NVarChar).Value = passportSubdivisionCodeOfOwner;

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

        public Guid GetIdOfOwner(string passportSeriesOfOwner,
                                 string passportNumberOfOwner,
                                 string passportSubdivisionCodeOfOwner)
        {
            Guid ownerId = Guid.NewGuid();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Owners
                                            WHERE passportSeriesOfOwner = @passportSeriesOfOwner
	                                              AND passportNumberOfOwner = @passportNumberOfOwner
	                                              AND passportSubdivisionCodeOfOwner = @passportSubdivisionCodeOfOwner";
                    command.Parameters.Add("@passportSeriesOfOwner", SqlDbType.NVarChar).Value = passportSeriesOfOwner;
                    command.Parameters.Add("@passportNumberOfOwner", SqlDbType.NVarChar).Value = passportNumberOfOwner;
                    command.Parameters.Add("@passportSubdivisionCodeOfOwner", SqlDbType.NVarChar).Value = passportSubdivisionCodeOfOwner;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ownerId = (Guid)reader[0];
                        }
                    }

                    connection.Close();
                }
            }

            return ownerId;
        }
    }
}
