using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using api.Db.Context;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Produces("application/json")]
    [Route("api/companies")]
    public class CompaniesController : Controller
    {
        public MyDbContext _dbContext { get; }

        public CompaniesController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _dbContext.Companies.ToListAsync();
            return new OkObjectResult(companies);
        }
    }
}