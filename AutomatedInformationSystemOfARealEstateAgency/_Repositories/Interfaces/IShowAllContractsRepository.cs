using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces
{
    public interface IShowAllContractsRepository
    {
        List<ContractsModel> GetAllContractsInformation(string inputValue);

        ContractsModel GetContractById(Guid ContractId);
        OwnerModel GetOwnerById(Guid OwnerId);
        BuyerModel GetBuyerById(Guid BuyerId);
        FlatModel GetFlatById(Guid FlatId);
        EmployeeModel GetEmployeeById(Guid EmployeeId);
    }
}
