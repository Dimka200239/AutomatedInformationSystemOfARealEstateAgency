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
    public partial class ShowInformationAboutFlatView : Form, IShowInformationAboutFlatView
    {
        public ShowInformationAboutFlatView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate { LoadInformationAboutFlatEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string SetCityOfApartment
        {
            get { return cityOfApartmentInputBox.Text; }
            set { cityOfApartmentInputBox.Text = value; }
        }

        public string SetAvenueOfApartment
        {
            get { return avenueOfApartmentInputBox.Text; }
            set { avenueOfApartmentInputBox.Text = value; }
        }

        public string SetHouseOfApartment
        {
            get { return houseOfApartmentInputBox.Text; }
            set { houseOfApartmentInputBox.Text = value; }
        }

        public int SetCountOfRoomsOfApartment
        {
            get { return Convert.ToInt32(countOfRoomsOfApartmentInputBox.Text); }
            set { countOfRoomsOfApartmentInputBox.Text = value.ToString(); }
        }

        public float SetTotalAreaOfApartment
        {
            get { return float.Parse(totalAreaOfApartmentInputBox.Text); }
            set { totalAreaOfApartmentInputBox.Text = value.ToString(); }
        }

        public float SetKitchenAreaOfApartment
        {
            get { return float.Parse(kitchenAreaOfApartmentInputBox.Text); }
            set { kitchenAreaOfApartmentInputBox.Text = value.ToString(); }
        }

        public string SetPresenceOfABalconyOfApartment
        {
            get { return presenceOfABalconyOfApartmentInputBox.Text; }
            set { presenceOfABalconyOfApartmentInputBox.Text = value; }
        }

        public string SetBathroomOfApartment
        {
            get { return bathroomOfApartmentInputBox.Text; }
            set { bathroomOfApartmentInputBox.Text = value; }
        }

        public int SetFloorOfApartment
        {
            get { return int.Parse(floorOfApartmentInputBox.Text); }
            set { floorOfApartmentInputBox.Text = value.ToString(); }
        }

        public int SetNumberOfApartment
        {
            get { return int.Parse(numberOfApartmentInputBox.Text); }
            set { numberOfApartmentInputBox.Text = value.ToString(); }
        }

        public int SetBuiltYearOfApartment
        {
            get { return int.Parse(builtYearOfApartmentInputBox.Text); }
            set { builtYearOfApartmentInputBox.Text = value.ToString(); }
        }

        public int SetRenovationYearOfApartment
        {
            get { return int.Parse(renovationYearOfApartmentInputBox.Text); }
            set { renovationYearOfApartmentInputBox.Text = value.ToString(); }
        }

        public string SetAvailabilityOfParkingOfApartment
        {
            get { return availabilityOfParkingOfApartmentInputBox.Text; }
            set { availabilityOfParkingOfApartmentInputBox.Text = value; }
        }

        public float SetDistanceFromMetroOfApartment
        {
            get { return float.Parse(distanceFromMetroOfApartmentInputBox.Text); }
            set { distanceFromMetroOfApartmentInputBox.Text = value.ToString(); }
        }

        public float SetDistanceFromCenterOfApartment
        {
            get { return float.Parse(distanceFromCenterOfApartmentInputBox.Text); }
            set { distanceFromCenterOfApartmentInputBox.Text = value.ToString(); }
        }

        public float SetLivingSpaceOfApartment
        {
            get { return float.Parse(livingSpaceOfApartmentInputBox.Text); }
            set { livingSpaceOfApartmentInputBox.Text = value.ToString(); }
        }

        public string SetRoomTypeOfApartment
        {
            get { return roomTypeOfApartmentInputBox.Text; }
            set { roomTypeOfApartmentInputBox.Text = value; }
        }

        public string SetWindowsExitOfApartment
        {
            get { return windowsExitOfApartmentInputBox.Text; }
            set { windowsExitOfApartmentInputBox.Text = value; }
        }

        public string SetRepairTypeOfApartment
        {
            get { return repairTypeOfApartmentInputBox.Text; }
            set { repairTypeOfApartmentInputBox.Text = value; }
        }

        public int SetNumberOfOwnersOfApartment
        {
            get { return int.Parse(numberOfOwnersOfApartmentInputBox.Text); }
            set { numberOfOwnersOfApartmentInputBox.Text = value.ToString(); }
        }

        public string SetDescriptionOfApartment
        {
            get { return descriptionOfApartmentInputBox.Text; }
            set { descriptionOfApartmentInputBox.Text = value; }
        }

        public float SetApartmentPrice
        {
            get { return float.Parse(apartmentPriceInputBox.Text); }
            set { apartmentPriceInputBox.Text = value.ToString(); }
        }

        public string SetOwnerName
        {
            get { return OwnerNameInputBox.Text; }
            set { OwnerNameInputBox.Text = value; }
        }

        public string SetOwnerSerName
        {
            get { return OwnerSerNameInputBox.Text; }
            set { OwnerSerNameInputBox.Text = value; }
        }

        public string SetOwnerpatronymic
        {
            get { return OwnerPatronymicInputBox.Text; }
            set { OwnerPatronymicInputBox.Text = value; }
        }

        public string SetOwnerPhone
        {
            get { return OwnerPhoneInputBox.Text; }
            set { OwnerPhoneInputBox.Text = value; }
        }

        public event EventHandler LoadInformationAboutFlatEvent;

        // Единождое открытие
        private static ShowInformationAboutFlatView instance;

        public static ShowInformationAboutFlatView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ShowInformationAboutFlatView();
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
