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
    public partial class AddNewFlatView : Form, IAddNewFlatView
    {
        public AddNewFlatView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public void AssociateAndRaiseViewEvents()
        {
            this.AddNewFlatButton.Click += delegate { AddNewFlatEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string GetCityOfApartment
        {
            get { return cityOfApartmentInputBox.Text; }
            set { }
        }

        public string GetAvenueOfApartment
        {
            get { return avenueOfApartmentInputBox.Text; }
            set { }
        }

        public string GetHouseOfApartment
        {
            get { return houseOfApartmentInputBox.Text; }
            set { }
        }

        public string GetCountOfRoomsOfApartment
        {
            get { return countOfRoomsOfApartmentInputBox.Text; }
            set { }
        }

        public string GetTotalAreaOfApartment
        {
            get { return totalAreaOfApartmentInputBox.Text; }
            set { }
        }

        public string GetKitchenAreaOfApartment
        {
            get { return kitchenAreaOfApartmentInputBox.Text; }
            set { }
        }

        public string GetPresenceOfABalconyOfApartment
        {
            get { return presenceOfABalconyOfApartmentInputBox.Text; }
            set { }
        }

        public string GetBathroomOfApartment
        {
            get { return bathroomOfApartmentInputBox.Text; }
            set { }
        }

        public string GetFloorOfApartment
        {
            get { return floorOfApartmentInputBox.Text; }
            set { }
        }

        public string GetNumberOfApartment
        {
            get { return numberOfApartmentInputBox.Text; }
            set { }
        }

        public string GetBuiltYearOfApartment
        {
            get { return builtYearOfApartmentInputBox.Text; }
            set { }
        }

        public string GetRenovationYearOfApartment
        {
            get { return renovationYearOfApartmentInputBox.Text; }
            set { }
        }

        public string GetAvailabilityOfParkingOfApartment
        {
            get { return availabilityOfParkingOfApartmentInputBox.Text; }
            set { }
        }

        public string GetDistanceFromMetroOfApartment
        {
            get { return distanceFromMetroOfApartmentInputBox.Text; }
            set { }
        }

        public string GetDistanceFromCenterOfApartment
        {
            get { return distanceFromCenterOfApartmentInputBox.Text; }
            set { }
        }

        public string GetLivingSpaceOfApartment
        {
            get { return livingSpaceOfApartmentInputBox.Text; }
            set { }
        }

        public string GetRoomTypeOfApartment
        {
            get { return roomTypeOfApartmentInputBox.Text; }
            set { }
        }

        public string GetWindowsExitOfApartment
        {
            get { return windowsExitOfApartmentInputBox.Text; }
            set { }
        }

        public string GetRepairTypeOfApartment
        {
            get { return repairTypeOfApartmentInputBox.Text; }
            set { }
        }

        public string GetNumberOfOwnersOfApartment
        {
            get { return numberOfOwnersOfApartmentInputBox.Text; }
            set { }
        }

        public string GetDescriptionOfApartment
        {
            get { return descriptionOfApartmentInputBox.Text; }
            set { }
        }

        public string GetApartmentPrice
        {
            get { return apartmentPriceInputBox.Text; }
            set { }
        }

        public void ShowInformation(string message)
        {
            MessageBox.Show(message);
        }

        public void SetSettingForComboBox()
        {
            throw new NotImplementedException();
        }

        public event EventHandler AddNewFlatEvent;

        // Единождое открытие
        private static AddNewFlatView instance;

        public static AddNewFlatView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddNewFlatView();
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
