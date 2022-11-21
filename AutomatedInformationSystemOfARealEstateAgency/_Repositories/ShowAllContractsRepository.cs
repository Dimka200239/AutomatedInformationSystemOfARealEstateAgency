using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    public class ShowAllContractsRepository : BaseRepository, IShowAllContractsRepository
    {
        public ShowAllContractsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<ContractsModel> GetAllContractsInformation(string inputValue)
        {
            var contractList = new List<ContractsModel>();
            contractList.Clear();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM ContractsForThePurchaseOfAnApartment
                                            WHERE date LIKE @newValueString + '%'";
                    command.Parameters.Add("@newValueString", SqlDbType.NVarChar).Value = inputValue;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newContract = new ContractsModel();

                            newContract.ContractId = (Guid)reader[0];
                            newContract.Ownerid = (Guid)reader[1];
                            newContract.BuyerId = (Guid)reader[2];
                            newContract.ApartmentId = (Guid)reader[3];
                            newContract.EmployeeId = (Guid)reader[4];
                            newContract.Date = reader[5].ToString();
                            newContract.Price = float.Parse(reader[6].ToString());
                            newContract.CashFlow = float.Parse(reader[7].ToString());

                            contractList.Add(newContract);
                        }
                    }

                    connection.Close();
                }
            }

            return contractList;
        }

        public ContractsModel GetContractById(Guid ContractId)
        {
            var contract = new ContractsModel();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM ContractsForThePurchaseOfAnApartment
                                            WHERE idOfOwnerContract = @id";

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = ContractId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newContract = new ContractsModel();

                            newContract.ContractId = (Guid)reader[0];
                            newContract.Ownerid = (Guid)reader[1];
                            newContract.BuyerId = (Guid)reader[2];
                            newContract.ApartmentId = (Guid)reader[3];
                            newContract.EmployeeId = (Guid)reader[4];
                            newContract.Date = reader[5].ToString();
                            newContract.Price = float.Parse(reader[6].ToString());
                            newContract.CashFlow = float.Parse(reader[7].ToString());

                            contract = newContract;
                        }
                    }

                    connection.Close();
                }
            }

            return contract;
        }

        public BuyerModel GetBuyerById(Guid BuyerId)
        {
            var buyer = new BuyerModel();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM Buyers
                                            WHERE idOfBuyer = @id"
                    ;

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = BuyerId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newBuyer = new BuyerModel();

                            newBuyer.NameOfBuyer = reader[1].ToString();
                            newBuyer.SerNameOfBuyer = reader[2].ToString();
                            newBuyer.PatronymicOfBuyer = reader[3].ToString();
                            newBuyer.PassportSeriesOfBuyer = reader[6].ToString();
                            newBuyer.PassportNumberOfBuyer = reader[7].ToString();
                            newBuyer.PassportSubdivisionCodeOfBuyer = reader[8].ToString();

                            buyer = newBuyer;
                        }
                    }

                    connection.Close();
                }
            }

            return buyer;
        }

        public EmployeeModel GetEmployeeById(Guid EmployeeId)
        {
            var employee = new EmployeeModel();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM Employees
                                            WHERE idOfEmployee = @id";

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = EmployeeId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newEmployee = new EmployeeModel();

                            newEmployee.NameOfEmployee = reader[1].ToString();
                            newEmployee.SerNameOfEmployee = reader[2].ToString();
                            newEmployee.PatronymicOfEmployee = reader[3].ToString();

                            employee = newEmployee;
                        }
                    }

                    connection.Close();
                }
            }

            return employee;
        }

        public FlatModel GetFlatById(Guid FlatId)
        {
            var flat = new FlatModel();

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT *
                                            FROM Apartments
                                            WHERE idOfApartment = @id";

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = FlatId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newFlat = new FlatModel();

                            newFlat.CityOfApartment = reader[1].ToString();
                            newFlat.AvenueOfApartment = reader[2].ToString();
                            newFlat.HouseOfApartment = reader[3].ToString();
                            newFlat.ApartmentPrice = float.Parse(reader[22].ToString());

                            flat = newFlat;
                        }
                    }

                    connection.Close();
                }
            }

            return flat;
        }

        public OwnerModel GetOwnerById(Guid OwnerId)
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

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = OwnerId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newOwner = new OwnerModel();

                            newOwner.NameOfOwner = reader[1].ToString();
                            newOwner.SerNameOfOwner = reader[2].ToString();
                            newOwner.PatronymicOfOwner = reader[3].ToString();
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
