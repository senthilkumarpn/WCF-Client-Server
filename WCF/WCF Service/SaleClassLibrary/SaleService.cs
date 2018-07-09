using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;

namespace SaleClassLibrary
{
    class SaleService:ISaleService
    {
        public static List<Customer> customers = new List<Customer>() {
            new Customer { Id = 1, Name = "SenthilKumar", Address = "Address", Email = "senthil@gmail.com" },
            new Customer { Id = 2, Name = "RKumar", Address = "Address", Email = "Rkumar@gmail.com" },
            new Customer { Id = 3, Name = "Udhaya", Address = "Address", Email = "Udhaya@gmail.com" },
            new Customer { Id = 4, Name = "thiru", Address = "Address", Email = "thiru@gmail.com" },
            new Customer { Id = 5, Name = "umesh", Address = "Address", Email = "umesh@gmail.com" }
        };
        public bool InsertCustomer(Customer customer)
        {
            customers.Add(customer);
            return true;
        }
        public bool DeleteCustomer(int id)
        {
            var item = customers.FirstOrDefault(x => x.Id == id);
            customers.Remove(item);
            return true;
        }
        public bool UpdateCustomer(Customer customer)
        {
            customers.Where(x => x.Id == customer.Id).Update(c => c.Name = customer.Name);
            return true;
        }
        public List<Customer> GetAllCustomer()
        {
            List<Customer> customerlist = new List<Customer>();
            return customerlist;
        }
    }
    public static class LinqUpdates
    {
        public static void Update<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }
    }




}

