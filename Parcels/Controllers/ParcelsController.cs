using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcel/new")]
    public ActionResult CreateParcel()
    {
      return View();
    }

    [HttpPost("/parcel")]
    public ActionResult Create(string height, string length, string width, string weight)
    {
      Parcel newParcel = new Parcel(int.Parse(height), int.Parse(length), int.Parse(width), int.Parse(weight));
      return View("Index", newParcel);
    }

    [HttpPost("/parcel/sent")]
    public ActionResult Success()
    {
      Parcel recentParcel = Parcel.GetParcels[Parcel.GetParcels.Count];
      return View(recentParcel);
    }
  }
}