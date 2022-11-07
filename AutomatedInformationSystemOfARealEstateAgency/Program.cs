using AutomatedInformationSystemOfARealEstateAgency.Presenters;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AutomatedInformationSystemOfARealEstateAgency
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);

            Application.Run((Form)view);
        }
    }
}
