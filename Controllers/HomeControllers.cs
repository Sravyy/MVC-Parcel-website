using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/parcel")]
    public ActionResult Parcel()
    {
      ParcelVariable myParcel = new ParcelVariable();
      myParcel.SetParcel(Request.Query["length"],Request.Query["width"],Request.Query["height"],Request.Query["weight"]);
      return View("index", myParcel);
    }
  }
}
