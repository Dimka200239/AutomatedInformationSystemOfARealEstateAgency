using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedInformationSystemOfARealEstateAgency.Models
{
    public class ContractsModel
    {
        // Поля класса

        private Guid contractId;
        private Guid ownerid;
        private Guid buyerId;
        private Guid apartmentId;
        private Guid employeeId;
        private string date;
        private float price;
        private float cashFlow;


        // Свойства - Валидатор

        [DisplayName("Contract's ID")]
        public Guid ContractId
        {
            get { return contractId; }
            set { contractId = value; }
        }

        [DisplayName("Owner's ID")]
        public Guid Ownerid
        {
            get { return ownerid; }
            set { ownerid = value; }
        }

        [DisplayName("Buyer's ID")]
        public Guid BuyerId
        {
            get { return buyerId; }
            set { buyerId = value; }
        }

        [DisplayName("Apartment's ID")]
        public Guid ApartmentId
        {
            get { return apartmentId; }
            set { apartmentId = value; }
        }

        [DisplayName("Employee's ID")]
        public Guid EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        [DisplayName("Date")]
        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        [DisplayName("Price")]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        [DisplayName("CashFlow")]
        public float CashFlow
        {
            get { return cashFlow; }
            set { cashFlow = value; }
        }
    }
}
