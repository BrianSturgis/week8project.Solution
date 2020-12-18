using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
  [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "ciao"; }

    [Route("/")]
    public ActionResult Form() { return View(); }
  }
}