using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JqueryAjaxJsonSample.Models;
using JqueryAjaxJsonSample.Models.ViewModel;

namespace JqueryAjaxJsonSample.Controllers
{
    public class OrderController : Controller
    {
        private OrderDbcontext db=new OrderDbcontext();
        //
        // GET: /Order/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Order/Create
        public ActionResult Create()
        {
            return View();
        }


        public ActionResult Save(OrderViewModel model)
        {

            db.Orders.Add(model.Order);
            db.SaveChanges();
            return View("Create");

        }

        //
        // POST: /Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            return View();
        }

        //
        // GET: /Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Order/Edit/5
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

        //
        // GET: /Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Order/Delete/5
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
