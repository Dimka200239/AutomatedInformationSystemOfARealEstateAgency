using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class AddNewBuyerPresenter
    {
        // Поля

        private IAddNewBuyerView addNewBuyerView;
        private IAddNewBuyerRepository repository;
        private readonly string sqlConnectionString;

        // Поля для добавления нового договора
        private Guid ownerId;
        private Guid apartmentId;
        private Guid employeeId;
        private string date;
        private float price;
        private float cashFlow;

        public AddNewBuyerPresenter(IAddNewBuyerView view,
                                    IAddNewBuyerRepository repository,
                                    string sqlConnectionString,
                                    Guid ownerId,
                                    Guid apartmentId,
                                    Guid employeeId,
                                    string date,
                                    float price,
                                    float cashFlow)
{
            this.addNewBuyerView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;
            this.ownerId = ownerId;
            this.apartmentId = apartmentId;
            this.employeeId = employeeId;
            this.date = date;
            this.price = price;
            this.cashFlow = cashFlow;

            // Подписка на методы обработчика событий для просмотра событий
            addNewBuyerView.AddNewBuyerEvent += AddNewBuyer;

            // Показ представления
            this.addNewBuyerView.Show();
        }

        private void AddNewBuyer(object sender, EventArgs e)
        {
            try
            {
                var model = new BuyerModel();
                model.NameOfBuyer = addNewBuyerView.GetBuyerName;
                model.SerNameOfBuyer = addNewBuyerView.GetBuyerSerName;
                model.PatronymicOfBuyer = addNewBuyerView.GetBuyerPatronymic;
                model.YearOfBirthOfBuyer = Convert.ToInt32(addNewBuyerView.GetBuyerYearOfBirth);
                model.PhoneOfBuyer = addNewBuyerView.GetBuyerPhone;
                model.PassportSeriesOfBuyer = addNewBuyerView.GetBuyerSeriesPassport;
                model.PassportNumberOfBuyer = addNewBuyerView.GetBuyerNumberPassport;
                model.PassportSubdivisionCodeOfBuyer = addNewBuyerView.GetBuyerSubdivisionCodePassport;

                new Common.ModelDataValidation().Validate(model);

                if (this.repository.CheckInformationAboutBuyer(addNewBuyerView.GetBuyerSeriesPassport,
                                                           addNewBuyerView.GetBuyerNumberPassport,
                                                           addNewBuyerView.GetBuyerSubdivisionCodePassport))
                {
                    var newIdBuyer = Guid.NewGuid();

                    this.repository.AddNewBuyerInDataBase(newIdBuyer,
                                                          addNewBuyerView.GetBuyerName,
                                                          addNewBuyerView.GetBuyerSerName,
                                                          addNewBuyerView.GetBuyerPatronymic,
                                                          Convert.ToInt32(addNewBuyerView.GetBuyerYearOfBirth),
                                                          addNewBuyerView.GetBuyerPhone,
                                                          addNewBuyerView.GetBuyerSeriesPassport,
                                                          addNewBuyerView.GetBuyerNumberPassport,
                                                          addNewBuyerView.GetBuyerSubdivisionCodePassport);
                    addNewBuyerView.ShowInformation("Новый покупатель успешно добавлен!");
                }
                else
                {
                    addNewBuyerView.ShowInformation("Покупатель уже существует в базе данных.");
                }

                var resultBuyerId = repository.GetIdOfBuyer(addNewBuyerView.GetBuyerSeriesPassport,
                                                      addNewBuyerView.GetBuyerNumberPassport,
                                                      addNewBuyerView.GetBuyerSubdivisionCodePassport);

                var newIdContract = Guid.NewGuid();
                repository.AddNewContract(newIdContract, ownerId, resultBuyerId, apartmentId, employeeId, date, price, cashFlow);
                repository.TakApartmentOffTheMarket(apartmentId);

                addNewBuyerView.ShowInformation("Квартира успешно оформлена!");

                this.addNewBuyerView.Close();
            }
            catch (Exception ex)
            {
                addNewBuyerView.ShowInformation(ex.Message);
            }
        }
    }
}
