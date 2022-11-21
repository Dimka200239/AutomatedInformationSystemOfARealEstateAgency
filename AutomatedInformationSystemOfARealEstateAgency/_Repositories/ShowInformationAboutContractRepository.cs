using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    public class ShowInformationAboutContractRepository: BaseRepository, IShowInformationAboutContractRepository
    {
        public ShowInformationAboutContractRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
