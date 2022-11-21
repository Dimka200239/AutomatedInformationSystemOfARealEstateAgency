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
    public partial class AddNewBuyerView : Form, IAddNewBuyerView
    {
        public AddNewBuyerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public void AssociateAndRaiseViewEvents()
        {
            this.AddNewBuyerButton.Click += delegate { AddNewBuyerEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string GetBuyerName
        {
            get { return BuyerNameInputBox.Text; }
            set {}
        }

        public string GetBuyerSerName
        {
            get { return BuyerSerNameInputBox.Text; }
            set {}
        }

        public string GetBuyerPatronymic
        {
            get { return BuyerPatronymicInputBox.Text; }
            set {}
        }

        public string GetBuyerYearOfBirth
        {
            get { return BuyerYearOfBirthInputBox.Text; }
            set {}
        }

        public string GetBuyerPhone
        {
            get { return BuyerPhoneInputBox.Text; }
            set {}
        }

        public string GetBuyerSeriesPassport
        {
            get { return BuyerSeriesPassportInputBox.Text; }
            set {}
        }

        public string GetBuyerNumberPassport
        {
            get { return BuyerNumberPassportInputBox.Text; }
            set {}
        }

        public string GetBuyerSubdivisionCodePassport
        {
            get { return BuyerSubdivisionCodePassportInputBox.Text; }
            set {}
        }

        public event EventHandler AddNewBuyerEvent;

        public void ShowInformation(string message)
        {
            MessageBox.Show(message);
        }

        // Единождое открытие
        private static AddNewBuyerView instance;

        public static AddNewBuyerView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddNewBuyerView();
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
