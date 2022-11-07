using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IMainMenuView
    {
        // Методы
        void Show();
        void Close();
        void Hide();

        // События
        event EventHandler ShowAllFlatsEvent;
        event EventHandler ShowAllClientsEvent;
        event EventHandler AddNewFlatEvent;
        event EventHandler ShowShoppingStoreEvent;
        event EventHandler ExitEvent;
    }
}
