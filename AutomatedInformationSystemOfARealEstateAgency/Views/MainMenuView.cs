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
    public partial class MainMenuView : Form, IMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            this.SearchFlatButton.Click += delegate { ShowAllFlatsEvent?.Invoke(this, EventArgs.Empty); };
            this.SearchClientButton.Click += delegate { ShowAllClientsEvent?.Invoke(this, EventArgs.Empty); };
            this.AddNewFlatButton.Click += delegate { AddNewFlatEvent?.Invoke(this, EventArgs.Empty); };
            this.OutputShoppingStoreButton.Click += delegate { ShowShoppingStoreEvent?.Invoke(this, EventArgs.Empty); };
            this.ExitButton.Click += delegate { ExitEvent?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowAllFlatsEvent;
        public event EventHandler ShowAllClientsEvent;
        public event EventHandler AddNewFlatEvent;
        public event EventHandler ShowShoppingStoreEvent;
        public event EventHandler ExitEvent;

        // Единождое открытие
        private static MainMenuView instance;

        public static MainMenuView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new MainMenuView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
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
