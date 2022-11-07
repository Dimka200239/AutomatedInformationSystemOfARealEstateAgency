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
        }

        public event EventHandler AddNewOwnerEvent;

        public void GetAllInputValueOfNewOwner()
        {
            throw new NotImplementedException();
        }
    }
}
