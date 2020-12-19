using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
  
    [HttpGet("/")]
    public ActionResult Form()
    {
      FormVariable myFormVariable = new FormVariable();
      myFormVariable.Recipient = "Lina";
      myFormVariable.Sender = "Jasmine";
      return View(myFormVariable);
    }
    [HttpGet("/form1")]
    public ActionResult Form1() { return View(); }
    // [HttpGet("/form1")]
    // public ActionResult Form1() { return View(); }
  }
}
