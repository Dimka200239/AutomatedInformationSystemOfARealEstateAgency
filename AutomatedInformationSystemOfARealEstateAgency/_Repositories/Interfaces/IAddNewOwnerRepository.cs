using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces
{
    public interface IAddNewOwnerRepository
    {
        bool AddNewOwnerInDataBase(Guid id,
                                   string name,
                                   string serName,
                                   string patronymic,
                                   int yearOfBirth,
                                   string phone,
                                   string passportSeries,
                                   string passportNuber,
                                   string passportSubdivisionCode);

        bool CheckInformationAboutOwner(string passportSeriesOfOwner,
                                        string passportNumberOfOwner,
                                        string passportSubdivisionCodeOfOwner);

        Guid GetIdOfOwner(string passportSeriesOfOwner,
                          string passportNumberOfOwner,
                          string passportSubdivisionCodeOfOwner);
    }
}
