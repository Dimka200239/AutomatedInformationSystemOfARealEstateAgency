using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class ShowInformationAboutContractPresenter
    {
        // Поля
        private IShowInformationAboutContractView contractView;
        private IShowInformationAboutContractRepository repository;
        private readonly string sqlConnectionString;
        private readonly ContractsModel contractModel;
        private readonly OwnerModel ownerModel;
        private readonly BuyerModel buyerModel;
        private readonly FlatModel flatModel;
        private readonly EmployeeModel employeeModel;

        public ShowInformationAboutContractPresenter(IShowInformationAboutContractView view,
                                                     IShowInformationAboutContractRepository repository,
                                                     string sqlConnectionString,
                                                     ContractsModel contractModel,
                                                     OwnerModel ownerModel,
                                                     BuyerModel buyerModel,
                                                     FlatModel flatModel,
                                                     EmployeeModel employeeModel)
        {
            this.contractView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.contractModel = contractModel;
            this.ownerModel = ownerModel;
            this.buyerModel = buyerModel;
            this.flatModel = flatModel;
            this.employeeModel = employeeModel;

            this.contractView.ShowInformarionAboutContractEvent += ShowInformarionAboutContract;

            // Показ представления
            this.contractView.Show();
        }

        private void ShowInformarionAboutContract(object sender, EventArgs e)
        {
            contractView.ownerFIO = $"{ownerModel.SerNameOfOwner} {ownerModel.NameOfOwner} {ownerModel.PatronymicOfOwner}";
            contractView.buyerFio = $"{buyerModel.SerNameOfBuyer} {buyerModel.NameOfBuyer} {buyerModel.PatronymicOfBuyer}";
            contractView.ownerPassport = $"{ownerModel.PassportSeriesOfOwner}, {ownerModel.PassportNumberOfOwner}, {ownerModel.PassportSubdivisionCodeOfOwner}";
            contractView.buyerPassport = $"{buyerModel.PassportSeriesOfBuyer}, {buyerModel.PassportNumberOfBuyer}, {buyerModel.PassportSubdivisionCodeOfBuyer}";
            contractView.addressOfFlat = $"{flatModel.CityOfApartment}, {flatModel.AvenueOfApartment}, {flatModel.HouseOfApartment}";
            contractView.PriceText = flatModel.ApartmentPrice.ToString();
            contractView.EmployeeFIOText = $"{employeeModel.SerNameOfEmployee} {employeeModel.NameOfEmployee} {employeeModel.PatronymicOfEmployee}";
            contractView.CashText = contractModel.CashFlow.ToString();
            contractView.DateText = contractModel.Date;
        }
    }
}
