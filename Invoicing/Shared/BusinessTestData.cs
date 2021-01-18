using System;
using System.Collections.Generic;
using System.Linq;

namespace Invoicing.Shared
{
    public class BusinessTestData : IBusinessData
    {
        private List<Invoice> testInvoices = new List<Invoice>();
   
        public BusinessTestData()
        {
            
        }
        
        public List<Invoice> AllInvoices => testInvoices;

        public decimal SalesRevenue => testInvoices.Sum(invoice => invoice.Amount);

        public decimal Outstanding => (decimal)testInvoices.Sum(invoice => invoice.Amount - invoice.Paid);

        public decimal Restant => throw new NotImplementedException();

        public void Add(Invoice i)
        {
            throw new NotImplementedException();
        }
    }
}
