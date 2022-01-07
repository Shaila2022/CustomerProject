using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CustomerBL;
using CustomerDAL;

namespace CustomerProject.Controllers
{
    public class CustomersController : Controller
    {
        private CustomerBusiness BL = new CustomerBusiness();

        // GET: Customers
        public ActionResult Index()
        {
            return View(BL.GetCustomerlist());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(BL.Details(id));
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create[Bind(Include = "CustomerID,CustomerName,CustomerAge")]
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( tblCustomer tblCustomer)
        {
            if (ModelState.IsValid)
            {
                BL.Create(tblCustomer);
                return RedirectToAction("Index");
            }

            return View(tblCustomer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(BL.Details(id));
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,CustomerName,CustomerAge")] tblCustomer tblCustomer)
        {
            if (ModelState.IsValid)
            {
                BL.Create(tblCustomer);
                return RedirectToAction("Index");
            }
            return View(tblCustomer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(BL.Details(id));
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BL.DeleteConfirmed(id);
            return RedirectToAction("Index");
        }     
    }
}
