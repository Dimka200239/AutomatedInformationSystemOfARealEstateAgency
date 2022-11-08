using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IFlatView
    {
        void Show();
        void Close();
        void Hide();

        string GetInputValue();

        void SetEmployeeListBindingSourse(List<FlatModel> flatList);
        void SetSettingsForDataGridView(object sender, EventArgs e);
        List<string> GetSelectedRow();

        bool CheckInformationInDataGrid();

        event EventHandler SearchFlatEvent;
        event EventHandler ShowInfoAboutFlatEvent;
        event EventHandler ArrangeApartmentEvent;
    }
}
