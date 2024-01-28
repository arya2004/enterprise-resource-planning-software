using ApteConsultancy.Data;
using ApteConsultancy.Dto;
using ApteConsultancy.Dto.EmployeeDto;
using ApteConsultancy.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public ExpensesController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _responseDto = new ResponseDto();
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
        public ActionResult<ResponseDto> GetAll()
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("EMPLOYEE"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            List<OwnCarLocalAndOutStation> Projects = _appDbContext.OwnCarLocalAndOutStations.Include(_ => _.Project).ToList();
            _responseDto.Result = Projects;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpGet("GetOne")]

        public async Task<ActionResult<ResponseDto>> Get(int? number)
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("EMPLOYEE"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            OwnCarLocalAndOutStation? Projects = await _appDbContext.OwnCarLocalAndOutStations.Include(_ => _.Project ).FirstOrDefaultAsync(_ => _.OwnCarLocalAndOutStationId == number);
            _responseDto.Result = Projects;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }


        [HttpGet("GetForProject")]

        public async Task<ActionResult<ResponseDto>> GetForProject(int? number)
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("ADMIN"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            List<OwnCarLocalAndOutStation>? Projects =  _appDbContext.OwnCarLocalAndOutStations.Include(_ => _.Project).Where(_ => _.Project.ProjectId == number).ToList();
            _responseDto.Result = Projects;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }

        [HttpGet("GetForEmployee")]

        public async Task<ActionResult<ResponseDto>> GetForEmployee(string? employeeEmail)
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("ADMIN"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            List<OwnCarLocalAndOutStation>? Projects = _appDbContext.OwnCarLocalAndOutStations.Include(_ => _.Project).Where(_ => _.Employee.Email == employeeEmail).ToList();
            _responseDto.Result = Projects;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }







        [HttpPost("Create")]
        public async Task<ActionResult<ResponseDto>> Create([FromBody] CreateOwnCarLocalAndOutStationDto Project)
        {

            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("EMPLOYEE"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            OwnCarLocalAndOutStation OCLaOS = _mapper.Map<OwnCarLocalAndOutStation>(Project);
            var project = await _appDbContext.Projects.FirstOrDefaultAsync(_ => _.ProjectId == Project.ProjectId);
            var employee = await _appDbContext.ApplicationUsers.FirstOrDefaultAsync(_ => _.Email == email);
            OCLaOS.Project = project;
            OCLaOS.Employee = employee;


            try
            {
                _appDbContext.OwnCarLocalAndOutStations.Add(OCLaOS);
                await _appDbContext.SaveChangesAsync();
                _responseDto.Message = "Added Successfully";
                _responseDto.IsSuccess = true;
                return Ok(_responseDto);
            }
            catch (Exception ex)
            {

                _responseDto.Message = ex.Message;
                _responseDto.IsSuccess = false;
                return Ok(_responseDto);
            }

        }

        [HttpPut("Update")]
        public async Task<ActionResult<ResponseDto>> Edit(OwnCarLocalAndOutStation Project)
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("EMPLOYEE"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            OwnCarLocalAndOutStation ProjectToSave = _mapper.Map<OwnCarLocalAndOutStation>(Project);
            try
            {
                _appDbContext.OwnCarLocalAndOutStations.Update(ProjectToSave);
                await _appDbContext.SaveChangesAsync();
                _responseDto.Message = "Updated Successfully";
                _responseDto.IsSuccess = true;
                return Ok(_responseDto);
            }
            catch (Exception ex)
            {

                _responseDto.Message = ex.Message;
                _responseDto.IsSuccess = false;
                return Ok(_responseDto);
            }




        }


        [HttpDelete]
        [ActionName("Delete")]
        public async Task<ActionResult<ResponseDto>> Delete(int? number)
        {


            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            if (roles == null || roles.Count == 0 || email == null)
            {
                _responseDto.Message = "invalid token";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            if (!roles.Contains("EMPLOYEE"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            try
            {
                OwnCarLocalAndOutStation? Project = _appDbContext.OwnCarLocalAndOutStations.FirstOrDefault(_ => _.OwnCarLocalAndOutStationId== number);
                if (Project == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.OwnCarLocalAndOutStations.Remove(Project);
                await _appDbContext.SaveChangesAsync();
                _responseDto.Message = "Deleted Successfully";
                _responseDto.IsSuccess = true;
                return Ok(_responseDto);
            }
            catch (Exception ex)
            {

                _responseDto.Message = ex.Message;
                _responseDto.IsSuccess = false;
                return Ok(_responseDto);
            }


        }
    }
}
