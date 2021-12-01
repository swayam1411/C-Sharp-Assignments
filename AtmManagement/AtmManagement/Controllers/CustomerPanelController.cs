using AtmManagement.Models;
using System;
using System.Web.Mvc;

namespace AtmManagement.Controllers
{
    public class CustomerPanelController : Controller
    {
        CustomersContext customerDB = new CustomersContext();
        public ViewResult CustomerSection(Customers customer) => View(customer);

        public ActionResult Withdraw(long id)
        {
            Customers customer = customerDB.CustomersTable.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Withdraw(Customers upadateCustomer)
        {
            Customers customer = customerDB.CustomersTable.Find(upadateCustomer.AccountNo);

            if (customer.Balance >= upadateCustomer.Balance)
            {
                customer.Balance = customer.Balance - upadateCustomer.Balance;
                customerDB.SaveChanges();
                return RedirectToAction("CustomerSection",customer);
            }
            else
                return RedirectToAction("Insufficient", customer);
        }

        public ActionResult Transfer(long id)
        {
            Customers customer = customerDB.CustomersTable.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Transfer(Customers upadateCustomer , long receiverCustomerId)
        {
            Customers senderCustomer = customerDB.CustomersTable.Find(upadateCustomer.AccountNo);
            Customers receiverCustomer = customerDB.CustomersTable.Find(receiverCustomerId);

            if (senderCustomer.Balance >= upadateCustomer.Balance)
            {
                if(receiverCustomer != null)
                {
                    senderCustomer.Balance = senderCustomer.Balance - upadateCustomer.Balance;
                    receiverCustomer.Balance = receiverCustomer.Balance + upadateCustomer.Balance;
                    customerDB.SaveChanges();
                }
                else
                    return RedirectToAction("InvalidCustomer", senderCustomer);

                return RedirectToAction("CustomerSection", senderCustomer);
            }
            else
                return RedirectToAction("Insufficient", senderCustomer);
        }

        public ActionResult Insufficient(Customers customer) => View(customer);

        public ActionResult InvalidCustomer(Customers customer) => View(customer);

    }
}