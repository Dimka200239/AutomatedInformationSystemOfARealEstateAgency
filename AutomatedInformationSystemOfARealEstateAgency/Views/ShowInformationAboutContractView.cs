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
    public partial class ShowInformationAboutContractView : Form, IShowInformationAboutContractView
    {
        public ShowInformationAboutContractView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.Load += delegate { ShowInformarionAboutContractEvent?.Invoke(this, EventArgs.Empty); };
        }

        public string ownerFIO
        {
            get { return firstFIO.Text; }
            set { firstFIO.Text = value; }
        }

        public string buyerFio
        {
            get { return secondFIO.Text; }
            set { secondFIO.Text = value; }
        }

        public string ownerPassport
        {
            get { return firstPassport.Text; }
            set { firstPassport.Text = value; }
        }

        public string buyerPassport
        {
            get { return secondPassport.Text; }
            set { secondPassport.Text = value; }
        }

        public string addressOfFlat
        {
            get { return address.Text; }
            set { address.Text = value; }
        }

        string IShowInformationAboutContractView.PriceText
        {
            get { return priceText.Text; }
            set { priceText.Text = value; }
        }

        string IShowInformationAboutContractView.EmployeeFIOText
        {
            get { return employeeFIOText.Text; }
            set { employeeFIOText.Text = value; }
        }

        string IShowInformationAboutContractView.CashText
        {
            get { return cashText.Text; }
            set { cashText.Text = value; }
        }

        string IShowInformationAboutContractView.DateText
        {
            get { return dateText.Text; }
            set { dateText.Text = value; }
        }

        public event EventHandler ShowInformarionAboutContractEvent;

        // Единождое открытие
        private static ShowInformationAboutContractView instance;

        public static ShowInformationAboutContractView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ShowInformationAboutContractView();
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
