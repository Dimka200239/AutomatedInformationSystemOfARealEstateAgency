using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces
{
    public interface IAddNewFlatRepository
    {
        bool AddNewFlatInDataBase(Guid id,
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
                                  string status);

        bool CheckInformationAboutFlat(string city,
                                       string avenue,
                                       string house,
                                       int floor,
                                       int number,
                                       string status);
    }
}
