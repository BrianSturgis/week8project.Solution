using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
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

    
  }
}