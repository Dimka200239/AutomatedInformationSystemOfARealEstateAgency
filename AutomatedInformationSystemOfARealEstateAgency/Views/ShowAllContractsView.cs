using AutomatedInformationSystemOfARealEstateAgency.Models;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedInformationSystemOfARealEstateAgency.Views
{
    public partial class ShowAllContractsView : Form, IShowAllContractsView
    {
        public ShowAllContractsView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler SearchContractEvent;
        public event EventHandler ShowInfoAboutContractEvent;

        public void AssociateAndRaiseViewEvents()
        {
            this.Load += SetSettingsForDataGridView;
            SearchContractsButton.Click += delegate { SearchContractEvent?.Invoke(this, EventArgs.Empty); };
            InputFieldForSearchContracts.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Console.WriteLine(1);
                    SearchContractEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            ShowInfoAboutContractsButton.Click += delegate { ShowInfoAboutContractEvent?.Invoke(this, EventArgs.Empty); };
        }

        public bool CheckInformationInDataGrid()
        {
            if (DataSourseContracts.SelectedRows.Count == 0)
            {
                return false;
            }

            return true;
        }

        public string GetInputValue()
        {
            return InputFieldForSearchContracts.Text;
        }

        public List<string> GetSelectedRow()
        {
            var index = DataSourseContracts.SelectedCells[0].RowIndex;
            var flatListInformation = new List<string>();

            flatListInformation.Add(DataSourseContracts[0, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[1, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[2, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[3, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[4, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[5, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[6, index].Value.ToString());
            flatListInformation.Add(DataSourseContracts[7, index].Value.ToString());

            return flatListInformation;
        }

        public void SetContractListBindingSourse(List<ContractsModel> contractList)
        {
            DataSourseContracts.DataSource = contractList;
            DataSourseContracts.Columns["ContractId"].ReadOnly = true;
            DataSourseContracts.Columns["Ownerid"].ReadOnly = true;
            DataSourseContracts.Columns["BuyerId"].ReadOnly = true;
            DataSourseContracts.Columns["ApartmentId"].ReadOnly = true;
            DataSourseContracts.Columns["EmployeeId"].ReadOnly = true;
            DataSourseContracts.Columns["Date"].ReadOnly = true;
            DataSourseContracts.Columns["Price"].ReadOnly = true;
            DataSourseContracts.Columns["CashFlow"].ReadOnly = true;
        }

        public void SetSettingsForDataGridView(object sender, EventArgs e)
        {
            DataSourseContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataSourseContracts.AllowUserToAddRows = false;
        }

        // Единождое открытие
        private static ShowAllContractsView instance;

        public static ShowAllContractsView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ShowAllContractsView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Right;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }

                instance.BringToFront();
            }

            return instance;
        }
    }
}
