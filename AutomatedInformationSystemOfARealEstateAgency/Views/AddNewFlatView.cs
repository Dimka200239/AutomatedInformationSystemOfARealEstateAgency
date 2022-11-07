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
        }

        public event EventHandler AddNewFlatEvent;

        public void GetAllInputValueOfNewFlat()
        {
            throw new NotImplementedException();
        }
    }
}
