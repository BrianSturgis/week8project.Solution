using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
  
    [Route("/")]
    public ActionResult Form()
    {
      FormVariable myFormVariable = new FormVariable();
      myFormVariable.Recipient = "Lina";
      myFormVariable.Sender = "Jasmine";
      return View(myFormVariable);
    }
    [Route("/form1")]
    public ActionResult Form1() { return View(); }
  }
}