using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDAL
{
    public class CustomerDL
    {
        private CustumerDBEntities db = new CustumerDBEntities();
        public List<tblCustomer> GetCustomerlist()
        {
            return db.tblCustomers.ToList();
        }
        public tblCustomer Details(int? id)
        {
            return db.tblCustomers.Find(id);
        }
        public tblCustomer Create(tblCustomer tblCustomer)
        {
            if(tblCustomer.CustomerID ==0)
                db.tblCustomers.Add(tblCustomer);
            else
            db.Entry(tblCustomer).State = EntityState.Modified;
            db.SaveChanges();
            return tblCustomer;
        }
        public void DeleteConfirmed(int id)
        {
            tblCustomer tblCustomer = db.tblCustomers.Find(id);
            db.tblCustomers.Remove(tblCustomer);
            db.SaveChanges();
        }
    }
}
