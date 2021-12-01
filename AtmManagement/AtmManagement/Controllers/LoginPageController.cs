using AtmManagement.Models;
using System.Linq;
using System.Web.Mvc;

namespace AtmManagement.Controllers
{
    public class LoginPageController : Controller
    {
        public ViewResult SignIn() => View();

        public ViewResult AdminLogin() => View();

        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            using (var adminDetails = new AdminContext())
            {
                bool isValid = adminDetails.AdminTable.Any(x => x.Name == admin.Name && x.Password == admin.Password);
                if (isValid)
                    return RedirectToAction("AdminSection", "AdminPanel");
                else
                    return RedirectToAction("SignIn", "LoginPage");
            }
        }

        public ViewResult CustomerLogin() => View();

        [HttpPost]
        public ActionResult CustomerLogin(Customers customer)
        {
            CustomersContext customerDetails = new CustomersContext();

            try
            {
                Customers validCustomer = customerDetails.CustomersTable.Single(x => x.Name == customer.Name && x.Password == customer.Password);
                return RedirectToAction("CustomerSection", "CustomerPanel", validCustomer);
            }

            catch
            {
                return RedirectToAction("SignIn", "LoginPage");
            }

        }
    }
}