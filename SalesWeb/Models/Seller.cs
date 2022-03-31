using System;
using System.Collections.Generic;
using System.Linq;
namespace SalesWeb.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int iD, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            ID=iD;
            Name=name;
            Email=email;
            BirthDate=birthDate;
            BaseSalary=baseSalary;
            Department=department;
        }

        public void AddSales(SalesRecord sr)
        {
            SalesRecords.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            SalesRecords.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecords.Where(e => e.Date >= initial && e.Date >= final).Sum(e => e.Amount);
        }
    }
}
