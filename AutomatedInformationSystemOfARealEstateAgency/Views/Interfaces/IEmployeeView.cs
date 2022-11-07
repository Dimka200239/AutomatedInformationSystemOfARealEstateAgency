using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IEmployeeView
    {
        // Свойства - Поля
        string UserLogin { get; set; }
        string UserPassword { get; set; }

        // События
        event EventHandler SignInEvent;

        // Методы
        void Show();
        void Close();
        void Hide();
    }
}
