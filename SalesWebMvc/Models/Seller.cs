using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSaly { get; set; }
        public Department Department { get; set; }
        public ICollection<SelesRecord> Sales { get; set; } = new List<SelesRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSaly, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSaly = baseSaly;
            Department = department;
        }

        public void AddSales(SelesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SelesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime inicial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= inicial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
