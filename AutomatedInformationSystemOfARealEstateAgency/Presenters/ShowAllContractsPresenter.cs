using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class ShowAllContractsPresenter
    {
        // Поля
        private IMainView mainView;
        private IShowAllContractsView contractsView;
        private IShowAllContractsRepository repository;
        private readonly string sqlConnectionString;

        public ShowAllContractsPresenter(IMainView mainView, IShowAllContractsView view, IShowAllContractsRepository repository, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.contractsView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;

            // Подписка на методы обработчика событий для просмотра событий
            this.contractsView.SearchContractEvent += SearchContract;
            this.contractsView.ShowInfoAboutContractEvent += ShowInfoAboutContract;

            // Показ представления
            this.contractsView.Show();
        }

        private void SearchContract(object sender, EventArgs e)
        {
            var result = repository.GetAllContractsInformation(contractsView.GetInputValue());

            contractsView.SetContractListBindingSourse(result);
        }

        private void ShowInfoAboutContract(object sender, EventArgs e)
        {

        }
    }
}
