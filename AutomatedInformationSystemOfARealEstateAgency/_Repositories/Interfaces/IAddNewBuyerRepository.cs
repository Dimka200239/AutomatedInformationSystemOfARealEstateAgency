using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces
{
    public interface IAddNewBuyerRepository
    {
        bool AddNewBuyerInDataBase(Guid id,
                                   string name,
                                   string serName,
                                   string patronymic,
                                   int yearOfBirth,
                                   string phone,
                                   string passportSeries,
                                   string passportNuber,
                                   string passportSubdivisionCode);

        bool CheckInformationAboutBuyer(string passportSeriesOfBuyer,
                                        string passportNumberOfBuyer,
                                        string passportSubdivisionCodeOfBuyer);

        Guid GetIdOfBuyer(string passportSeriesOfBuyer,
                          string passportNumberOfBuyer,
                          string passportSubdivisionCodeOfBuyer);

        bool AddNewContract(Guid contractId,
                            Guid ownerId,
                            Guid buyerId,
                            Guid apartmentId,
                            Guid employeeId,
                            string date,
                            float price,
                            float cashFlow);

        bool TakApartmentOffTheMarket(Guid apartmentId);
    }
}
