using Microsoft.AspNetCore.Mvc;
using Job.Models;
using System.Collections.Generic;

namespace Job.Controllers
{
  public class HomeController : Controller
  {
    // [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Resume()
    {
      string yourName = Request.Form["your-name"];
      Jobs newJob = new Jobs(yourName);
      return View(newJob);
    }
  }
}
