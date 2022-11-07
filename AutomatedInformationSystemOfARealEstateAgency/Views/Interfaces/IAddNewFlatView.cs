using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IAddNewFlatView
    {
        void Show();
        void Hide();
        void Close();

        void GetAllInputValueOfNewFlat();

        event EventHandler AddNewFlatEvent;
    }
}
