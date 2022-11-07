using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    /// <summary>
    /// Класс, описывающий репозиторий для работы с окном посика квартиры
    /// </summary>
    public class FlatRepository : BaseRepository, IFlatRepository
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        public FlatRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Метод ищет и возвращается информацию по всем квартирам из БД по вводимому параметру
        /// </summary>
        /// <param name="inputValue">Вводимый параметр</param>
        /// <returns>Возвращает список квартир, которые удовлетворяют вводемому параметру</returns>
        public List<FlatModel> GetAllFlatInformation(string inputValue)
        {
            var flatList = new List<FlatModel>();

            var newValueString = "";
            var newValueInt = -1;
            float newValueFloat = -1;

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;

                    if (int.TryParse(inputValue, out newValueInt))
                    {
                        command.CommandText = @"SELECT *
                                                FROM Apartments
                                                WHERE countOfRoomsOfApartment LIKE @newValueInt + '%'
                                                    OR floorOfApartment LIKE @newValueInt + '%'
                                                    OR builtYearOfApartment LIKE @newValueInt + '%'
                                                    OR renovationYearOfApartment LIKE @newValueInt + '%'
                                                    OR numberOfOwnersOfApartment LIKE @newValueInt + '%'";

                        command.Parameters.Add("@newValueInt", SqlDbType.Int).Value = newValueInt;
                    }
                    else if (float.TryParse(inputValue, out newValueFloat))
                    {
                        command.CommandText = @"SELECT *
                                                FROM Apartments
                                                WHERE totalAreaOfApartment LIKE @newValueFloat + '%'
                                                    OR kitchenAreaOfApartment LIKE @newValueFloat + '%'
                                                    OR distanceFromMetroOfApartment LIKE @newValueFloat + '%'
                                                    OR distanceFromCenterOfApartment LIKE @newValueFloat + '%'
                                                    OR livingSpaceOfApartment LIKE @newValueFloat + '%'
                                                    OR apartmentPrice LIKE @newValueFloat + '%'";

                        command.Parameters.Add("@newValueFloat", SqlDbType.Float).Value = newValueFloat;
                    }
                    else
                    {
                        command.CommandText = @"SELECT *
                                                FROM Apartments
                                                WHERE addressOfApartment LIKE @newValueString + '%'
                                                    OR presenceOfABalconyOfApartment LIKE @newValueString + '%'
                                                    OR bathroomOfApartment LIKE @newValueString + '%'
                                                    OR availabilityOfParkingOfApartment LIKE @newValueString + '%'
                                                    OR roomTypeOfApartment LIKE @newValueString + '%'
                                                    OR windowsExitOfApartment LIKE @newValueString + '%'
                                                    OR repairTypeOfApartment LIKE @newValueString + '%'
                                                    OR descriptionOfApartment LIKE @newValueString + '%'
                                                    OR statusOfApartment LIKE @newValueString + '%'";

                        command.Parameters.Add("@newValueString", SqlDbType.NVarChar).Value = newValueString;
                    }
                    

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newFlat = new FlatModel();

                            newFlat.IdOfApartment = (Guid)reader[0];
                            newFlat.AddressOfApartment = reader[1].ToString();
                            newFlat.CountOfRoomsOfApartment = (int)reader[2];
                            newFlat.TotalAreaOfApartment = (float)reader[3];
                            newFlat.KitchenAreaOfApartment = (float)reader[4];
                            newFlat.PresenceOfABalconyOfApartment = reader[5].ToString();
                            newFlat.BathroomOfApartment = reader[6].ToString();
                            newFlat.FloorOfApartment = (int)reader[7];
                            newFlat.BuiltYearOfApartment = (int)reader[8];
                            newFlat.RenovationYearOfApartment = (int)reader[9];
                            newFlat.AvailabilityOfParkingOfApartment = reader[10].ToString();
                            newFlat.DistanceFromMetroOfApartment = (float)reader[11];
                            newFlat.DistanceFromCenterOfApartment = (float)reader[12];
                            newFlat.LivingSpaceOfApartment = (float)reader[13];
                            newFlat.RoomTypeOfApartment = reader[14].ToString();
                            newFlat.WindowsExitOfApartment = reader[15].ToString();
                            newFlat.RepairTypeOfApartment = reader[16].ToString();
                            newFlat.NumberOfOwnersOfApartment = (int)reader[17];
                            newFlat.DescriptionOfApartment = reader[18].ToString();
                            newFlat.ApartmentPrice = (float)reader[19];
                            newFlat.ApartmentOwner = (Guid)reader[20];
                            newFlat.StatusOfApartment = reader[21].ToString();

                            flatList.Add(newFlat);
                        }
                    }

                    connection.Close();
                }
            }

            return flatList;
        }
    }
}
