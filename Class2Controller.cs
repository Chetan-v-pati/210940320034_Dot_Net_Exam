using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationMVC.Controllers
{
    public class Class2Controller : Controller
    {
        public object ProductId { get; private set; }
        public object ProductName { get; private set; }
        public object Rate { get; private set; }
        public object Description { get; private set; }
        public object CategoryName { get; private set; }

        // GET: Class2
        public ActionResult Index()
        {
            List <Products> prdts = new List <Products>();
            return View();
        }

        // GET: Class2/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Class2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Class2/Create
        [HttpPost]
        public ActionResult Create(Class2Controller prdts)
        {
            try
            {
                // TODO: Add insert logic here
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(localdb)\ProjectsV13; Initial Catalog = JkJan22; Integrated Security =True";
                cn.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into products (ProductId) values (@ProductId), (ProductName) values (@ProductName), (Rate) values (@Rate), (Description) values (@Description), (CategoryName) values (@CategoryName)  ";


                cmd.Parameters.AddWithValue("@ProductId", prdts.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", prdts.ProductName);
                cmd.Parameters.AddWithValue("@Rate", prdts.Rate);
                cmd.Parameters.AddWithValue("@Description", prdts.Description);
                cmd.Parameters.AddWithValue("@CategoryName", prdts.CategoryName);
                


                cmd.ExecuteNonQuery();
                cn.Close();

                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Class2/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Class2/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Class2/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Class2/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
