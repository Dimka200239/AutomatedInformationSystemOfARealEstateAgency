using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this.mainView.ShowUserView += ShowUsersView;
        }

        private void ShowUsersView(object sender, EventArgs e)
        {
            IEmployeeView view = EmployeeView.GetInstance((MainView)mainView);
            IEmployeeRepository repository = new EmployeeRepository(sqlConnectionString);
            new EmployeePresenter(mainView, view, repository, sqlConnectionString);
        }
    }
}
