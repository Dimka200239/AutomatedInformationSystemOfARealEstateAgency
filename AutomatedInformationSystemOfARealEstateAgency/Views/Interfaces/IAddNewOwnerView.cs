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

        void ShowInformation(string message);

        string GetOwnerName { get; set; }
        string GetOwnerSerName { get; set; }
        string GetOwnerpatronymic { get; set; }
        int GetOwnerYearOfBirth { get; set; }
        string GetOwnerPhone { get; set; }
        string GetOwnerSeriesPassport { get; set; }
        string GetOwnerNumberPassport { get; set; }
        string GetOwnerSubdivisionCodePassport { get; set; }

        event EventHandler AddNewOwnerEvent;
    }
}
