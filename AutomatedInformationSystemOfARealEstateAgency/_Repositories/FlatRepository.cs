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
            flatList.Clear();

            var newValueInt = -1;
            float newValueFloat = -1;
            var notSale = "В продаже";

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
                                                WHERE (countOfRoomsOfApartment <= @newValueInt
                                                    OR floorOfApartment <= @newValueInt
                                                    OR numberOfApartment <= @newValueInt
                                                    OR builtYearOfApartment <= @newValueInt
                                                    OR renovationYearOfApartment <= @newValueInt
                                                    OR numberOfOwnersOfApartment <= @newValueInt)
                                                    AND statusOfApartment = @sale";

                        command.Parameters.Add("@newValueInt", SqlDbType.Int).Value = newValueInt;
                        command.Parameters.Add("@sale", SqlDbType.NVarChar).Value = notSale;
                    }
                    else if (float.TryParse(inputValue, out newValueFloat))
                    {
                        command.CommandText = @"SELECT *
                                                FROM Apartments
                                                WHERE (totalAreaOfApartment <= @newValueFloat
                                                    OR kitchenAreaOfApartment <= @newValueFloat
                                                    OR distanceFromMetroOfApartment <= @newValueFloat
                                                    OR distanceFromCenterOfApartment <= @newValueFloat
                                                    OR livingSpaceOfApartment <= @newValueFloat
                                                    OR apartmentPrice <= @newValueFloat)
                                                    AND statusOfApartment = @sale";

                        command.Parameters.Add("@newValueFloat", SqlDbType.Float).Value = newValueFloat;
                        command.Parameters.Add("@sale", SqlDbType.NVarChar).Value = notSale;
                    }
                    else
                    {
                        command.CommandText = @"SELECT *
                                                FROM Apartments
                                                WHERE (cityOfApartment LIKE @newValueString + '%'
                                                    OR avenueOfApartment LIKE @newValueString + '%'
                                                    OR houseOfApartment LIKE @newValueString + '%'
                                                    OR presenceOfABalconyOfApartment LIKE @newValueString + '%'
                                                    OR bathroomOfApartment LIKE @newValueString + '%'
                                                    OR availabilityOfParkingOfApartment LIKE @newValueString + '%'
                                                    OR roomTypeOfApartment LIKE @newValueString + '%'
                                                    OR windowsExitOfApartment LIKE @newValueString + '%'
                                                    OR repairTypeOfApartment LIKE @newValueString + '%'
                                                    OR descriptionOfApartment LIKE @newValueString + '%'
                                                    OR statusOfApartment LIKE @newValueString + '%')
                                                    AND statusOfApartment = @sale";

                        command.Parameters.Add("@newValueString", SqlDbType.NVarChar).Value = inputValue;
                        command.Parameters.Add("@sale", SqlDbType.NVarChar).Value = notSale;
                    }


                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newFlat = new FlatModel();

                            newFlat.IdOfApartment = (Guid)reader[0];
                            newFlat.CityOfApartment = reader[1].ToString();
                            newFlat.AvenueOfApartment = reader[2].ToString();
                            newFlat.HouseOfApartment = reader[3].ToString();
                            newFlat.CountOfRoomsOfApartment = (int)reader[4];
                            newFlat.TotalAreaOfApartment = float.Parse(reader[5].ToString());
                            newFlat.KitchenAreaOfApartment = float.Parse(reader[6].ToString());
                            newFlat.PresenceOfABalconyOfApartment = reader[7].ToString();
                            newFlat.BathroomOfApartment = reader[8].ToString();
                            newFlat.FloorOfApartment = (int)reader[9];
                            newFlat.NumberOfApartment = (int)reader[10];
                            newFlat.BuiltYearOfApartment = (int)reader[11];
                            newFlat.RenovationYearOfApartment = (int)reader[12];
                            newFlat.AvailabilityOfParkingOfApartment = reader[13].ToString();
                            newFlat.DistanceFromMetroOfApartment = float.Parse(reader[14].ToString());
                            newFlat.DistanceFromCenterOfApartment = float.Parse(reader[15].ToString());
                            newFlat.LivingSpaceOfApartment = float.Parse(reader[16].ToString());
                            newFlat.RoomTypeOfApartment = reader[17].ToString();
                            newFlat.WindowsExitOfApartment = reader[18].ToString();
                            newFlat.RepairTypeOfApartment = reader[19].ToString();
                            newFlat.NumberOfOwnersOfApartment = (int)reader[20];
                            newFlat.DescriptionOfApartment = reader[21].ToString();
                            newFlat.ApartmentPrice = float.Parse(reader[22].ToString());
                            newFlat.ApartmentOwner = (Guid)reader[23];
                            newFlat.StatusOfApartment = reader[24].ToString();

                            flatList.Add(newFlat);
                        }
                    }

                    connection.Close();
                }
            }

            return flatList;
        }

        public OwnerModel GetOwnerById(Guid idOwner)
        {
            var owner = new OwnerModel();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM Owners
                                            WHERE idOfOwner = @id";

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = idOwner;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newOwner = new OwnerModel();

                            newOwner.IdOfOwner = (Guid)reader[0];
                            newOwner.NameOfOwner = reader[1].ToString();
                            newOwner.SerNameOfOwner = reader[2].ToString();
                            newOwner.PatronymicOfOwner = reader[3].ToString();
                            newOwner.YearOfBirthOfOwner = (int)reader[4];
                            newOwner.PhoneOfOwner = reader[5].ToString();
                            newOwner.PassportSeriesOfOwner = reader[6].ToString();
                            newOwner.PassportNumberOfOwner = reader[7].ToString();
                            newOwner.PassportSubdivisionCodeOfOwner = reader[8].ToString();

                            owner = newOwner;
                        }
                    }

                    connection.Close();
                }
            }

            return owner;
        }
    }
}
