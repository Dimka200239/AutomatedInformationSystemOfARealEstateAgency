using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс, реализующий репозиторий для работы с окном поиска квартир
    /// </summary>
    public interface IFlatRepository
    {
        /// <summary>
        /// Метод ищет и возвращается информацию по всем квартирам из БД по вводимому параметру
        /// </summary>
        /// <param name="inputValue">Вводимый параметр</param>
        /// <returns>Возвращает список квартир, которые удовлетворяют вводемому параметру</returns>
        List<FlatModel> GetAllFlatInformation(string inputValue);

        OwnerModel GetOwnerById(Guid idOwner);
    }
}
