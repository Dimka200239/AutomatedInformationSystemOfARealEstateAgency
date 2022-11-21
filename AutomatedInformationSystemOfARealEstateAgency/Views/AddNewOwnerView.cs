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
    public partial class AddNewOwnerView : Form, IAddNewOwnerView
    {
        public AddNewOwnerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public void AssociateAndRaiseViewEvents()
        {
            this.AddNewOwnerButton.Click += delegate { AddNewOwnerEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string GetOwnerName
        {
            get { return OwnerNameInputBox.Text; }
            set {}
        }

        public string GetOwnerSerName
        {
            get { return OwnerSerNameInputBox.Text; }
            set { }
        }

        public string GetOwnerpatronymic
        {
            get { return OwnerPatronymicInputBox.Text; }
            set { }
        }

        public string GetOwnerYearOfBirth
        {
            get { return OwnerYearOfBirthInputBox.Text; }
            set { }
        }

        public string GetOwnerPhone
        {
            get { return OwnerPhoneInputBox.Text; }
            set { }
        }

        public string GetOwnerSeriesPassport
        {
            get { return OwnerSeriesPassportInputBox.Text; }
            set { }
        }

        public string GetOwnerNumberPassport
        {
            get { return OwnerNumberPassportInputBox.Text; }
            set { }
        }

        public string GetOwnerSubdivisionCodePassport
        {
            get { return OwnerSubdivisionCodePassportInputBox.Text; }
            set { }
        }

        public void ShowInformation(string message)
        {
            MessageBox.Show(message);
        }

        public event EventHandler AddNewOwnerEvent;

        // Единождое открытие
        private static AddNewOwnerView instance;

        public static AddNewOwnerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AddNewOwnerView();
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
