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
    public partial class FlatView : Form, IFlatView
    {
        public FlatView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler SearchFlatEvent;
        public event EventHandler ShowInfoAboutFlatEvent;
        public event EventHandler ArrangeApartmentEvent;

        public void AssociateAndRaiseViewEvents()
        {
            this.Load += SetSettingsForDataGridView;
            SearchFlatButton.Click += delegate { SearchFlatEvent?.Invoke(this, EventArgs.Empty); };
            InputFieldForSearchFlat.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchFlatEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            ShowInfoAboutFlatButton.Click += delegate { ShowInfoAboutFlatEvent?.Invoke(this, EventArgs.Empty); };
            ArrangeApartmentButton.Click += delegate { ArrangeApartmentEvent?.Invoke(this, EventArgs.Empty); };
        }

        public bool CheckInformationInDataGrid()
        {
            if (DataSourseFlat.SelectedRows.Count == 0)
            {
                return false;
            }

            return true;
        }

        public string GetInputValue()
        {
            return InputFieldForSearchFlat.Text;
        }

        public List<string> GetSelectedRow()
        {
            var index = DataSourseFlat.SelectedCells[0].RowIndex;
            var flatListInformation = new List<string>();

            flatListInformation.Add(DataSourseFlat[0, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[1, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[2, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[3, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[4, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[5, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[6, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[7, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[8, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[9, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[10, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[11, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[12, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[13, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[14, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[15, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[16, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[17, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[18, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[19, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[20, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[21, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[22, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[23, index].Value.ToString());
            flatListInformation.Add(DataSourseFlat[24, index].Value.ToString());

            return flatListInformation;
        }

        public void SetEmployeeListBindingSourse(List<FlatModel> flatList)
        {
            DataSourseFlat.DataSource = flatList;
            DataSourseFlat.Columns["IdOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["CityOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["AvenueOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["HouseOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["CountOfRoomsOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["TotalAreaOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["KitchenAreaOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["PresenceOfABalconyOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["BathroomOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["FloorOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["NumberOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["BuiltYearOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["RenovationYearOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["AvailabilityOfParkingOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["DistanceFromMetroOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["DistanceFromCenterOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["LivingSpaceOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["RoomTypeOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["WindowsExitOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["RepairTypeOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["NumberOfOwnersOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["DescriptionOfApartment"].ReadOnly = true;
            DataSourseFlat.Columns["ApartmentPrice"].ReadOnly = true;
            DataSourseFlat.Columns["ApartmentOwner"].ReadOnly = true;
            DataSourseFlat.Columns["StatusOfApartment"].ReadOnly = true;
        }

        public void SetSettingsForDataGridView(object sender, EventArgs e)
        {
            DataSourseFlat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataSourseFlat.AllowUserToAddRows = false;
        }

        // Единождое открытие
        private static FlatView instance;

        public static FlatView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FlatView();
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
