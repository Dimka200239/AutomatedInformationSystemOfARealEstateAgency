using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces
{
    public interface IShowAllContractsView
    {
        void Show();
        void Close();
        void Hide();

        string GetInputValue();

        void SetContractListBindingSourse(List<ContractsModel> contractList);
        void SetSettingsForDataGridView(object sender, EventArgs e);
        List<string> GetSelectedRow();

        bool CheckInformationInDataGrid();

        event EventHandler SearchContractEvent;
        event EventHandler ShowInfoAboutContractEvent;
    }
}
