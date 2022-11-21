using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IShowInformationAboutContractView
    {
        void Show();
        void Hide();
        void Close();

        string ownerFIO { get; set; }
        string buyerFio { get; set; }
        string ownerPassport { get; set; }
        string buyerPassport { get; set; }
        string addressOfFlat { get; set; }
        string PriceText { get; set; }
        string EmployeeFIOText { get; set; }
        string CashText { get; set; }
        string DateText { get; set; }

        event EventHandler ShowInformarionAboutContractEvent;
    }
}
