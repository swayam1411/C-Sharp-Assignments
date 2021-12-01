using AtmManagement.Models;
using System.Linq;
using System.Web.Mvc;

namespace AtmManagement.Controllers
{
    public class AdminPanelController : Controller
    {
        CustomersContext customerDB = new CustomersContext();
        public ViewResult AdminSection() => View(customerDB.CustomersTable.ToList());

        public ActionResult Details(long id)
        {
            Customers customer = customerDB.CustomersTable.Find(id);
            return View(customer);
        }

        public ActionResult Create() => View();

        [HttpPost]
        public ActionResult Create(Customers customer)
        {
            customerDB.CustomersTable.Add(customer);
            customerDB.SaveChanges();

            return RedirectToAction("AdminSection");
        }

        public ActionResult AddMoney(long id)
        {
            Customers customer = customerDB.CustomersTable.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult AddMoney(Customers upadateCustomer)
        {
            Customers customer = customerDB.CustomersTable.Find(upadateCustomer.AccountNo);
            customer.Balance = customer.Balance + upadateCustomer.Balance;
            customerDB.SaveChanges();

            return RedirectToAction("AdminSection");
        }

        public ActionResult Delete(long id)
        {
            Customers customer = customerDB.CustomersTable.Find(id);
            return View(customer);
        }

        [HttpPost]
        public ActionResult Delete(Customers customer)
        {
            Customers removeCustomer = customerDB.CustomersTable.Find(customer.AccountNo);

            if (removeCustomer.Balance == 0)
            {
                customerDB.CustomersTable.Remove(removeCustomer);
                customerDB.SaveChanges();
            }
            else
                return View("ZeroBalance");

            return RedirectToAction("AdminSection");
        }

    }
}