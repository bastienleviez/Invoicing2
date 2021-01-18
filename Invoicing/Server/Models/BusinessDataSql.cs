using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Invoicing.Shared;
using Dapper;

namespace Invoicing.Server.Models
{
    public class BusinessDataSql : IBusinessData, IDisposable
    {
        private List<Invoice> listInvoices;
        private SqlConnection cnct;
        public BusinessDataSql(string connexionString)
        {
            this.cnct = new SqlConnection(connexionString);
            cnct.Open();
            this.listInvoices = (List<Invoice>)cnct.Query<Invoice>("SELECT * FROM invoice");
            cnct.Close();
        }
        public void Dispose()
        {
            this.cnct.Dispose();
        }

        public List<Invoice> AllInvoices => this.listInvoices;

        public decimal SalesRevenue => this.AllInvoices.Sum(invoice => invoice.Paid);

        public decimal Outstanding => this.AllInvoices.Sum(invoice => invoice.Amount - invoice.Paid);

        public decimal Restant => this.AllInvoices.Sum(invoice => invoice.Amount);

        public void Add(Invoice i)
        {
            this.cnct.Open();
            string sql = "INSERT INTO invoice (Reference, Customer, Amount, Created, Expected) VALUES (@refer, @customer, @amount, @created, @expected)";
            this.cnct.Execute(sql, new { refer=i.Reference , customer=i.Customer, amount=i.Amount, created=i.Created, expected=i.Expected});
            this.listInvoices = (List<Invoice>)this.cnct.Query<Invoice>("SELECT * FROM invoice");
            cnct.Close();

        }

    }
}
