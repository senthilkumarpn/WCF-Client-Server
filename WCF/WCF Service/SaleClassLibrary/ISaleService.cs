using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SaleClassLibrary
{
    [ServiceContract]
    interface ISaleService
    {
        [OperationContract]
        List<Customer> GetAllCustomer();

        [OperationContract]
        bool InsertCustomer(Customer customer);

        [OperationContract]
        bool DeleteCustomer(int id);

        [OperationContract]
        bool UpdateCustomer(Customer customer);

    }
    [DataContract]
    class Customer
    {
        [DataMember]
        public int Id;

        [DataMember]
        public string Name;

        [DataMember]
        public string Email;

        [DataMember]
        public string Address;
    }
}
