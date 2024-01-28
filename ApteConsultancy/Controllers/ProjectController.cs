using ApteConsultancy.Data;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Models.Master;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private IMapper _mapper;

        public ProjectController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;

            List<Project> Projects = _appDbContext.Projects.ToList();
            return Ok(Projects);
        }

        [HttpGet("GetOne")]

        public async Task<IActionResult> Get(string? name)
        {
            Project? Projects = await _appDbContext.Projects.FirstOrDefaultAsync(_ => _.Name == name);
            return Ok(Projects);
        }



        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] ProjectDto projectdto)
        //{
        //    Project project = _mapper.Map<Project>(projectdto);
        // //   Architect? a = await _appDbContext.Architects.FirstOrDefaultAsync(_ => _.CompanyName == projectdto.CompanyId);
        //    Company? c = await _appDbContext.Companies.FirstOrDefaultAsync(_ => _.Name == projectdto.Name);
        //    Client? cl = await _appDbContext.Clients.FirstOrDefaultAsync(_ => _.ClientName == projectdto.ClientId);


        //    var Users = await _appDbContext.ApplicationUsers.Where(a => projectdto.AssiciateAndEmployees.Contains(a)).ToListAsync();

        //    // Create a new book
        //    var newBook = new Book
        //    {
        //        Title = createBookDto.Title,
        //        AuthorBooks = existingAuthors.Select(author => new AuthorBook { Author = author }).ToList()
        //    };

        //    // Add the new book to the context and save changes
        //    _appDbContext.Projects.Add(project);
        //    await _appDbContext.SaveChangesAsync();
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> CreateProject([FromBody] ProjectDto projectDto)
        {
            try
            {
                // Retrieve associated entities from the database based on the provided IDs
                var company = await _appDbContext.Companies.FindAsync(projectDto.CompanyId);
                var client = await _appDbContext.Clients.FindAsync(projectDto.ClientId);
                var architect = await _appDbContext.Architects.FindAsync(projectDto.ArchitectId);
                var associateAndEmployees = await _appDbContext.Users
                    .Where(u => projectDto.AssociateAndEmployees.Contains(u.Email))
                    .ToListAsync();

                var newProject = new Project
                {
                   
                    Company = company,
                    Client = client,
                    Architect = architect,
                    ProjectCode = projectDto.ProjectCode,
                    Name = projectDto.Name,
                    ClientWoNumber = projectDto.ClientWoNumber,
                    Start = projectDto.Start,
                    End = projectDto.End,
                    Services = projectDto.Services,
                    ProjecLocation = projectDto.ProjecLocation,
                    TotalFees = projectDto.TotalFees,
                    FeesReceived = projectDto.FeesReceived,
                    FeesBalance = projectDto.FeesBalance,
                    Expenses = projectDto.Expenses,
                    ProfitAmount = projectDto.ProfitAmount,
                    IsCompleted = projectDto.IsCompleted
                };

                // Associate users with the project
                foreach (var user in associateAndEmployees)
                {
                    newProject.ApplicationUsers.Add(user);
                }

                // Add the new project to the context and save changes
                _appDbContext.Projects.Add(newProject);
                await _appDbContext.SaveChangesAsync();

                return Ok(new { Message = "Project created successfully." });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = $"Error creating project: {ex.Message}" });
            }
        }

        [HttpPut]
        public async Task<IActionResult> Edit(Project Project)
        {

            _appDbContext.Projects.Update(Project);
            await _appDbContext.SaveChangesAsync();
            return Ok("Edited");
        }


        [HttpDelete]
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(string? name)
        {
            Project? Project = _appDbContext.Projects.FirstOrDefault(_ => _.Name    == name);
            if (Project == null)
            {
                return NotFound();
            }
            _appDbContext.Projects.Remove(Project);
            await _appDbContext.SaveChangesAsync();
            return Ok("Deleted successfully");
        }
    }
}
