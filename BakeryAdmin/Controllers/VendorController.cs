using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using BakeryAdmin.Models;

namespace BakeryAdmin.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription  )
    {
      Vendor newVendor = new Vendor (vendorName,vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrder = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Order", vendorOrder);
      return View(model);
    }

    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/vendors/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderDescription, "1","1","1");
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("Vendor", foundVendor);
      return View("Show", model);
    }
  }
}