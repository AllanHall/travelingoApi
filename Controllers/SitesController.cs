using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using travelingoapi.models;
using travelingoapi;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace travelingoapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SitesController : ControllerBase
  {
    private DatabaseContext _context;

    public SitesController(DatabaseContext context)
    {
      this._context = context;
    }

    [HttpGet]
    public async Task<List<Site>> GetAllSites()
    {
      return await _context.Sites.ToListAsync();
    }

    [HttpGet("language")]
    public async Task<List<Site>> GetSitesByLanguage([FromQuery] string searchTerm)
    {
      var rv = _context.Sites.Where(w => w.Language.ToLower().Contains(searchTerm.ToLower()));
      return await rv.ToListAsync();
    }
  }
}