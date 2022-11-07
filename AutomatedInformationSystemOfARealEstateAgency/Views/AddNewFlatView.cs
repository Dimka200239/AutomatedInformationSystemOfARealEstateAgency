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

        public int GetCountOfRoomsOfApartment
        {
            get { return Convert.ToInt32(countOfRoomsOfApartmentInputBox.Text); }
            set { }
        }

        public float GetTotalAreaOfApartment
        {
            get { return float.Parse(totalAreaOfApartmentInputBox.Text); }
            set { }
        }

        public float GetKitchenAreaOfApartment
        {
            get { return float.Parse(kitchenAreaOfApartmentInputBox.Text); }
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

        public int GetFloorOfApartment
        {
            get { return Convert.ToInt32(floorOfApartmentInputBox.Text); }
            set { }
        }

        public int GetNumberOfApartment
        {
            get { return Convert.ToInt32(numberOfApartmentInputBox.Text); }
            set { }
        }

        public int GetBuiltYearOfApartment
        {
            get { return Convert.ToInt32(builtYearOfApartmentInputBox.Text); }
            set { }
        }

        public int GetRenovationYearOfApartment
        {
            get { return Convert.ToInt32(renovationYearOfApartmentInputBox.Text); }
            set { }
        }

        public string GetAvailabilityOfParkingOfApartment
        {
            get { return availabilityOfParkingOfApartmentInputBox.Text; }
            set { }
        }

        public float GetDistanceFromMetroOfApartment
        {
            get { return float.Parse(distanceFromMetroOfApartmentInputBox.Text); }
            set { }
        }

        public float GetDistanceFromCenterOfApartment
        {
            get { return float.Parse(distanceFromCenterOfApartmentInputBox.Text); }
            set { }
        }

        public float GetLivingSpaceOfApartment
        {
            get { return float.Parse(livingSpaceOfApartmentInputBox.Text); }
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

        public int GetNumberOfOwnersOfApartment
        {
            get { return Convert.ToInt32(numberOfOwnersOfApartmentInputBox.Text); }
            set { }
        }

        public string GetDescriptionOfApartment
        {
            get { return descriptionOfApartmentInputBox.Text; }
            set { }
        }

        public float GetApartmentPrice
        {
            get { return float.Parse(apartmentPriceInputBox.Text); }
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
