using AspNetCoreCURDMVC_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreCURDMVC_Demo.Controllers
{
    public class CustomerController : Controller
    {
        CustomerDataAccess_Layer objCustomer = new CustomerDataAccess_Layer();
        private readonly IConfiguration _configuration;
        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Create_customer()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
            List<Customer> customers = new List<Customer>();
            customers = objCustomer.GetAllCustomers(con).ToList();
            return View(customers);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create_customer([Bind] Customer cust)
        {
            if (ModelState.IsValid)
            {
                SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
                objCustomer.AddCustomer(con,cust);
                return RedirectToAction("Index");
            }
            return View(objCustomer);
        }
       
        public IActionResult Edit_customer(int? id)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
            if (id == null)
            {
                return NotFound();
            }
            Customer customer = objCustomer.GetCustomerData(con,id);

            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit_customer(int id, [Bind] Customer cust)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
            if (id != cust.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                objCustomer.UpdateCustomer(con,cust);
                return RedirectToAction("Index");
            }
            return View(objCustomer);
        }
        [HttpGet]
        public IActionResult customer_Details(int? id)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
            if (id == null)
            {
                return NotFound();
            }
            Customer objcustomer = objCustomer.GetCustomerData(con,id);

            if (objcustomer == null)
            {
                return NotFound();
            }
            return View(objcustomer);
        }
        [HttpGet]
        public IActionResult Delete_customer(int? id)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
            if (id == null)
            {
                return NotFound();
            }
            Customer objcustomer = objCustomer.GetCustomerData(con,id);

            if (objcustomer == null)
            {
                return NotFound();
            }
            return View(objcustomer);
        }

        [HttpPost, ActionName("Delete_customer")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("DBCS").ToString());
            objCustomer.DeleteCustomer(con,id);
            return RedirectToAction("Index");
        }
    }
}