using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
  [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "ciao"; }

    [Route("/")]
    public ActionResult Form()
    {
      FormVariable myFormVariable = new FormVariable();
      myFormVariable.Recipient = "Lina";
      myFormVariable.Sender = "Jasmine";
      return View(myFormVariable);
    }
  }
}