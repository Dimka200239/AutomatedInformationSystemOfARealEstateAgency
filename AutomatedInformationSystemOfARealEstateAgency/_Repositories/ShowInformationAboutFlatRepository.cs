using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories
{
    public class ShowInformationAboutFlatRepository : BaseRepository, IShowInformationAboutFlatRepository
    {
        public ShowInformationAboutFlatRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
