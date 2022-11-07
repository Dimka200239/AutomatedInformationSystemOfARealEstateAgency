using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AutomatedInformationSystemOfARealEstateAgency.Models;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    public class AddNewFlatRepository : BaseRepository, IAddNewFlatRepository
    {
        public AddNewFlatRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddNewFlatInDataBase(Guid id,
                                         string city,
                                         string avenue,
                                         string house,
                                         int countOfRooms,
                                         float totalArea,
                                         float kitchenArea,
                                         string presenceOfABalcony,
                                         string bathroom,
                                         int floor,
                                         int number,
                                         int builtYear,
                                         int renovationYear,
                                         string availabilityOfParking,
                                         float distanceFromMetro,
                                         float distanceFromCenter,
                                         float livingSpace,
                                         string roomType,
                                         string windowsExit,
                                         string repairType,
                                         int numberOfOwners,
                                         string description,
                                         float price,
                                         Guid owner,
                                         string status)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Apartments
                                            VALUES (@id, " +
                                                   "@city, " +
                                                   "@avenue, " +
                                                   "@house, " +
                                                   "@countOfRooms, " +
                                                   "@totalArea, " +
                                                   "@kitchenArea, " +
                                                   "@presenceOfABalcony, " +
                                                   "@bathroom, " +
                                                   "@floor, " +
                                                   "@number, " +
                                                   "@builtYear, " +
                                                   "@renovationYear, " +
                                                   "@availabilityOfParking, " +
                                                   "@distanceFromMetro, " +
                                                   "@distanceFromCenter, " +
                                                   "@livingSpace, " +
                                                   "@roomType, " +
                                                   "@windowsExit, " +
                                                   "@repairType, " +
                                                   "@numberOfOwners, " +
                                                   "@description, " +
                                                   "@price, " +
                                                   "@owner, " +
                                                   "@status)";
                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = id;
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
                    command.Parameters.Add("@avenue", SqlDbType.NVarChar).Value = avenue;
                    command.Parameters.Add("@house", SqlDbType.NVarChar).Value = house;
                    command.Parameters.Add("@countOfRooms", SqlDbType.Int).Value = countOfRooms;
                    command.Parameters.Add("@totalArea", SqlDbType.Float).Value = totalArea;
                    command.Parameters.Add("@kitchenArea", SqlDbType.Float).Value = kitchenArea;
                    command.Parameters.Add("@presenceOfABalcony", SqlDbType.NVarChar).Value = presenceOfABalcony;
                    command.Parameters.Add("@bathroom", SqlDbType.NVarChar).Value = bathroom;
                    command.Parameters.Add("@floor", SqlDbType.Int).Value = floor;
                    command.Parameters.Add("@number", SqlDbType.Int).Value = number;
                    command.Parameters.Add("@builtYear", SqlDbType.Int).Value = builtYear;
                    command.Parameters.Add("@renovationYear", SqlDbType.Int).Value = renovationYear;
                    command.Parameters.Add("@availabilityOfParking", SqlDbType.NVarChar).Value = availabilityOfParking;
                    command.Parameters.Add("@distanceFromMetro", SqlDbType.Float).Value = distanceFromMetro;
                    command.Parameters.Add("@distanceFromCenter", SqlDbType.Float).Value = distanceFromCenter;
                    command.Parameters.Add("@livingSpace", SqlDbType.Float).Value = livingSpace;
                    command.Parameters.Add("@roomType", SqlDbType.NVarChar).Value = roomType;
                    command.Parameters.Add("@windowsExit", SqlDbType.NVarChar).Value = windowsExit;
                    command.Parameters.Add("@repairType", SqlDbType.NVarChar).Value = repairType;
                    command.Parameters.Add("@numberOfOwners", SqlDbType.Int).Value = numberOfOwners;
                    command.Parameters.Add("@description", SqlDbType.NVarChar).Value = description;
                    command.Parameters.Add("@price", SqlDbType.Float).Value = price;
                    command.Parameters.Add("@owner", SqlDbType.UniqueIdentifier).Value = owner;
                    command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }

            return true;
        }

        public bool CheckInformationAboutFlat(string city,
                                              string avenue,
                                              string house,
                                              int floor,
                                              int number,
                                              string status)
        {
            var countOfNotes = 0;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    command.CommandText = @"SELECT * FROM Apartments
                                            WHERE cityOfApartment = @city
	                                              AND avenueOfApartment = @avenue
	                                              AND houseOfApartment = @house
	                                              AND floorOfApartment = @floor
	                                              AND numberOfApartment = @number
	                                              AND statusOfApartment = @status";
                    command.Parameters.Add("@city", SqlDbType.NVarChar).Value = city;
                    command.Parameters.Add("@avenue", SqlDbType.NVarChar).Value = avenue;
                    command.Parameters.Add("@house", SqlDbType.NVarChar).Value = house;
                    command.Parameters.Add("@floor", SqlDbType.Int).Value = floor;
                    command.Parameters.Add("@number", SqlDbType.Int).Value = number;
                    command.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;

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
    }
}
