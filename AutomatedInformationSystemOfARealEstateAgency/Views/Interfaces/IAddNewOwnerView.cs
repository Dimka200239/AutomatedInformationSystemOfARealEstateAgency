using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IAddNewOwnerView
    {
        void Show();
        void Hide();
        void Close();

        void GetAllInputValueOfNewOwner();

        event EventHandler AddNewOwnerEvent;
    }
}
