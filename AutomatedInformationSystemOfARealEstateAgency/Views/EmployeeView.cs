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
    public partial class EmployeeView : Form, IEmployeeView
    {
        public EmployeeView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            ToComeInButton.Click += delegate { SignInEvent?.Invoke(this, EventArgs.Empty); };
            PassWordInputField.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SignInEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        // Свойства
        public string UserLogin
        {
            get { return LoginInputField.Text; }
            set { LoginInputField.Text = value; }
        }

        public string UserPassword
        {
            get { return PassWordInputField.Text; }
            set { PassWordInputField.Text = value; }
        }

        // События
        public event EventHandler SignInEvent;
        public event EventHandler Successful;
        public event EventHandler Unsuccessful;
        public event EventHandler ShowEmployeeView;

        // Единождое открытие
        private static EmployeeView instance;

        public static EmployeeView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new EmployeeView();
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
