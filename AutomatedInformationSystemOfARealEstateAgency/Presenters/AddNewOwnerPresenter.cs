using AutomatedInformationSystemOfARealEstateAgency._Repositories;
using AutomatedInformationSystemOfARealEstateAgency._Repositories.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Views;
using AutomatedInformationSystemOfARealEstateAgency.Views.Interfaces;
using AutomatedInformationSystemOfARealEstateAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedInformationSystemOfARealEstateAgency.Presenters
{
    public class AddNewOwnerPresenter
    {
        // Поля

        private IMainView mainView;
        private IAddNewOwnerView addNewOwnerView;
        private IAddNewOwnerRepository repository;
        private readonly string sqlConnectionString;

        public AddNewOwnerPresenter(IMainView mainView, IAddNewOwnerView view, IAddNewOwnerRepository repository, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.addNewOwnerView = view;
            this.repository = repository;
            this.sqlConnectionString = sqlConnectionString;

            // Подписка на методы обработчика событий для просмотра событий
            addNewOwnerView.AddNewOwnerEvent += AddNewOwner;

            // Показ представления
            this.addNewOwnerView.Show();
        }

        private void AddNewOwner(object sender, EventArgs e)
        {
            try
            {
                var model = new OwnerModel();
                model.NameOfOwner = addNewOwnerView.GetOwnerName;
                model.SerNameOfOwner = addNewOwnerView.GetOwnerSerName;
                model.PatronymicOfOwner = addNewOwnerView.GetOwnerpatronymic;
                model.YearOfBirthOfOwner = Convert.ToInt32(addNewOwnerView.GetOwnerYearOfBirth);
                model.PhoneOfOwner = addNewOwnerView.GetOwnerPhone;
                model.PassportSeriesOfOwner = addNewOwnerView.GetOwnerSeriesPassport;
                model.PassportNumberOfOwner = addNewOwnerView.GetOwnerNumberPassport;
                model.PassportSubdivisionCodeOfOwner = addNewOwnerView.GetOwnerSubdivisionCodePassport;

                new Common.ModelDataValidation().Validate(model);

                if (this.repository.CheckInformationAboutOwner(addNewOwnerView.GetOwnerSeriesPassport,
                                                           addNewOwnerView.GetOwnerNumberPassport,
                                                           addNewOwnerView.GetOwnerSubdivisionCodePassport))
                {
                    var newIdOwner = Guid.NewGuid();

                    this.repository.AddNewOwnerInDataBase(newIdOwner,
                                                      addNewOwnerView.GetOwnerName,
                                                      addNewOwnerView.GetOwnerSerName,
                                                      addNewOwnerView.GetOwnerpatronymic,
                                                      Convert.ToInt32(addNewOwnerView.GetOwnerYearOfBirth),
                                                      addNewOwnerView.GetOwnerPhone,
                                                      addNewOwnerView.GetOwnerSeriesPassport,
                                                      addNewOwnerView.GetOwnerNumberPassport,
                                                      addNewOwnerView.GetOwnerSubdivisionCodePassport);
                    addNewOwnerView.ShowInformation("Новый владелец успешно добавлен!");
                }
                else
                {
                    addNewOwnerView.ShowInformation("Владелец уже существует в базе данных.");
                }

                var resultOwnerId = repository.GetIdOfOwner(addNewOwnerView.GetOwnerSeriesPassport,
                                                      addNewOwnerView.GetOwnerNumberPassport,
                                                      addNewOwnerView.GetOwnerSubdivisionCodePassport);

                this.addNewOwnerView.Close();

                IAddNewFlatView newView = AddNewFlatView.GetInstance((MainView)mainView);
                IAddNewFlatRepository newFlatRepository = new AddNewFlatRepository(sqlConnectionString);
                new AddNewFlatPresenter(mainView, newView, newFlatRepository, sqlConnectionString, resultOwnerId);
            }
            catch (Exception ex)
            {
                addNewOwnerView.ShowInformation(ex.Message);
            }
        }
    }
}
