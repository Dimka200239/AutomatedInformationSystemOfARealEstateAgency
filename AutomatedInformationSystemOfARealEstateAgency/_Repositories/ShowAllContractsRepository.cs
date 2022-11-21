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
                                            WHERE idOfOwner = @id";

                    command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = ContractId;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var newContract = new ContractsModel();

                            newContract.Ownerid = (Guid)reader[0];
                            newContract.BuyerId = (Guid)reader[1];
                            newContract.ApartmentId = (Guid)reader[2];
                            newContract.EmployeeId = (Guid)reader[3];
                            newContract.Date = reader[3].ToString();
                            newContract.Price = float.Parse(reader[3].ToString());
                            newContract.CashFlow = float.Parse(reader[3].ToString());

                            contract = newContract;
                        }
                    }

                    connection.Close();
                }
            }

            return contract;
        }
    }
}
