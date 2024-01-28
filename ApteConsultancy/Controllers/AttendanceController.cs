using ApteConsultancy.Data;
using ApteConsultancy.Dto.AdminDto;
using ApteConsultancy.Dto;
using ApteConsultancy.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ApteConsultancy.Dto.EmployeeDto;
using Microsoft.EntityFrameworkCore;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public AttendanceController(AppDbContext appDbContext, IMapper mapper)
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
            if (!roles.Contains("ADMIN"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            List<Employee_Attendance> Attendances = _appDbContext.Employee_Attendances.Where(_ => _.Employee.Email == email).ToList();
            _responseDto.Result = Attendances;
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
            if (!roles.Contains("ADMIN"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }

            Employee_Attendance? Attendances = await _appDbContext.Employee_Attendances.Include(_ => _.Employee).FirstOrDefaultAsync(_ => _.Employee_AttendanceId == number);
            _responseDto.Result = Attendances;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }

        [HttpGet("GetAttendanceForMonth")]
        public ActionResult<ResponseDto> GetAttendanceForMonth(int year, int month)
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

            // Assuming ApplicationUser has an Email property
            List<Employee_Attendance> Attendances = _appDbContext.Employee_Attendances
                .Where(a => a.Employee.Email == email && a.Date.Year == year && a.Date.Month == month)
                .ToList();

            _responseDto.Result = Attendances;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpGet("GetAttendanceForMonthADMIN")]
        public ActionResult<ResponseDto> GetAttendanceForMonthADMIN(int year, int month, string EmployeeEmail)
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

            // Assuming ApplicationUser has an Email property
            List<Employee_Attendance> Attendances = _appDbContext.Employee_Attendances
                .Where(a => a.Employee.Email == EmployeeEmail && a.Date.Year == year && a.Date.Month == month)
                .ToList();

            _responseDto.Result = Attendances;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }




        [HttpPost("Create")]
        public async Task<ActionResult<ResponseDto>> Create([FromBody] CreateAttendanceDto Attendance)
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

            Employee_Attendance AttendanceToSave = _mapper.Map<Employee_Attendance>(Attendance);
            var employee = await _appDbContext.ApplicationUsers.FirstOrDefaultAsync(_ => _.Email == email);
            AttendanceToSave.Employee = employee;
            try
            {
                _appDbContext.Employee_Attendances.Add(AttendanceToSave);
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
        public async Task<ActionResult<ResponseDto>> Edit(Employee_Attendance Attendance)
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

            Employee_Attendance AttendanceToSave = _mapper.Map<Employee_Attendance>(Attendance);
            try
            {
                _appDbContext.Employee_Attendances.Update(AttendanceToSave);
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
            if (!roles.Contains("ADMIN"))
            {
                _responseDto.Message = "unauthorized";
                _responseDto.IsSuccess = false;
                return _responseDto;
            }
            try
            {
                Employee_Attendance? Attendance = _appDbContext.Employee_Attendances.FirstOrDefault(_ => _.Employee_AttendanceId == number);
                if (Attendance == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.Employee_Attendances.Remove(Attendance);
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
