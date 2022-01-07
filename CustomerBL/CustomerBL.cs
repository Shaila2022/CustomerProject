using CustomerDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBL
{
    public class CustomerBusiness
    {
        CustomerDL DAL = new CustomerDL();
        public List<tblCustomer> GetCustomerlist()
        {
            return DAL.GetCustomerlist();
        }
        public tblCustomer Details(int? id)
        {
            return DAL.Details(id);
        }
        public tblCustomer Create(tblCustomer tblCustomer)
        {
            return DAL.Create(tblCustomer);
        }
        public void DeleteConfirmed(int id)
        {
             DAL.DeleteConfirmed(id);
        }
    }
}
