using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IAddNewBuyerView
    {
        void Show();
        void Hide();
        void Close();

        void ShowInformation(string message);

        string GetBuyerName { get; set; }
        string GetBuyerSerName { get; set; }
        string GetBuyerPatronymic { get; set; }
        int GetBuyerYearOfBirth { get; set; }
        string GetBuyerPhone { get; set; }
        string GetBuyerSeriesPassport { get; set; }
        string GetBuyerNumberPassport { get; set; }
        string GetBuyerSubdivisionCodePassport { get; set; }

        event EventHandler AddNewBuyerEvent;
    }
}
