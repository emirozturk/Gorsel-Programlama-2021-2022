using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uygulama8.Models;

namespace Uygulama8.Controllers
{
    internal class CustomerController
    {
        ServiceDbContext dbContext;
        public CustomerController()
        {
            dbContext = new ServiceDbContext();
        }

        public List<Customer> KullanicilariAl()
        {
            return dbContext.Customers.ToList();
        }
        public void Ekle(Customer kullanici)
        {
            dbContext.Customers.Add(kullanici);
            dbContext.SaveChanges();
        }
        public Customer Bul(string isim)
        {
            return dbContext.Customers.Where(x => x.Name == isim).FirstOrDefault();
        }
        public void Guncelle(Customer customer)
        {
            dbContext.Customers.Update(customer);
            dbContext.SaveChanges();
        }
        public void Sil(Customer customer)
        {
            dbContext.Customers.Remove(customer);
            dbContext.SaveChanges();
        }
    }
}
