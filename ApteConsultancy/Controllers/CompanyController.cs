using ApteConsultancy.Data;
using ApteConsultancy.Models.Master;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public CompanyController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {   
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            Console.WriteLine(email);
            List<Company> companies = _appDbContext.Companies.ToList();
            return Ok(companies);
        }

        [HttpGet("GetOne")]

        public async Task<IActionResult> Get(string? name)
        {
            Company? companies = await _appDbContext.Companies.FirstOrDefaultAsync(_ => _.Name == name);
            return Ok(companies);
        }



        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Company company)
        {   
            
                _appDbContext.Companies.Add(company);
                await _appDbContext.SaveChangesAsync();
                return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Company company)
        {
           
                _appDbContext.Companies.Update(company);
            await _appDbContext.SaveChangesAsync();
            return Ok("Edited");
        }

      
        [HttpDelete]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(    string? name)
        {
            Company? company = _appDbContext.Companies.FirstOrDefault(_ => _.Name == name);
            if (company == null)
            {
                return NotFound();
            }
            _appDbContext.Companies.Remove(company);
           await _appDbContext.SaveChangesAsync();
            return Ok("Deleted successfully");
        }
    }
}
