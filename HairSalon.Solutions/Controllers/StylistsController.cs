using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace HairSalon.Controllers
{
  public class StylistsController : Controller
  {
    private readonly HairSalonContext _db;
    public StylistsController(HairSalonContext db)
    {
      _db = db;
    }
    [HttpGet, ActionName("Index")]
    public ActionResult Index()
    {
     
      List<Stylist> model = _db.Stylists.ToList();
      return View(model);
    }
    [HttpGet, ActionName("Create")]
    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Stylist stylist)
    {
      _db.Stylists.Add(stylist);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


    [HttpGet, ActionName("Details")]
    public ActionResult Details(int id)
    {
      Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      thisStylist.Clients = _db.Clients.Where(client => client.StylistId == id).ToList();
      return View(thisStylist);
    }

  }
}