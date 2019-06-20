using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using travelingoapi.models;

namespace travelingoapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PlacesController : ControllerBase
  {
    private DatabaseContext db;
    public PlacesController()
    {
      this.db = new DatabaseContext();
    }

    // [HttpGet]
    // public ActionResult<List<model> Get()
    // {
    //   var rv = db.Places;
    //   return rv.ToList();
    // }
  }
}