using ApteConsultancy.Data;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Dto;
using ApteConsultancy.Models.Master;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using ApteConsultancy.Dto.DropdownDto;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchitectController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public ArchitectController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _responseDto = new ResponseDto();
            _mapper = mapper;
        }
        [HttpGet("GetAll")]
  
        public ActionResult<ResponseDto> GetAll()
        {
            //var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            //var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            //if(roles == null  || roles.Count == 0 || email == null)
            //{
            //    _responseDto.Message = "invalid token";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}
            //if (!roles.Contains("ADMIN"))
            //{
            //    _responseDto.Message = "unauthorized";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}

            List<Architect> companies = _appDbContext.Architects.ToList();
            _responseDto.Result = companies;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpGet("GetAllForDropdown")]
        public async Task<ActionResult<ResponseDto>> GetAllForDropdown()
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            //if (roles == null || roles.Count == 0 || email == null)
            //{
            //    _responseDto.Message = "invalid token";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}


            var companies = await _appDbContext.Companies.Select(u => new CompanyDropdownDto
            {
                CompanyId = u.CompanyId,
                CompanyCode = u.CompanyCode,
                Name = u.Name
            }).ToListAsync();


            _responseDto.Result = companies;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }



        [HttpGet("GetOne")]

        public async Task<ActionResult<ResponseDto>> Get(int id)
        {
            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            //if (roles == null || roles.Count == 0 || email == null)
            //{
            //    _responseDto.Message = "invalid token";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}
            //if (!roles.Contains("ADMIN"))
            //{
            //    _responseDto.Message = "unauthorized";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}

            Architect? companies = await _appDbContext.Architects.FirstOrDefaultAsync(_ => _.ArchitectId== id);
            _responseDto.Result = companies;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }



        [HttpPost]
        public async Task<ActionResult<ResponseDto>> Create([FromBody] ArchitectDto company)
        {

            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            //if (roles == null || roles.Count == 0 || email == null)
            //{
            //    _responseDto.Message = "invalid token";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}
            //if (!roles.Contains("ADMIN"))
            //{
            //    _responseDto.Message = "unauthorized";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}

            Architect companyToSave = _mapper.Map<Architect>(company);
            try
            {
                _appDbContext.Architects.Add(companyToSave);
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

        [HttpPut]
        public async Task<IActionResult> Edit(Architect company)
        {

            try
            {
                _appDbContext.Architects.Update(company);
                await _appDbContext.SaveChangesAsync();
                _responseDto.Message = "Edited Successfully";
                _responseDto.IsSuccess = true;

            }
            catch (Exception ex)
            {

                _responseDto.Message = ex.Message;
                _responseDto.IsSuccess = false;
            }

            return Ok(_responseDto);

        }


        [HttpDelete]
        [ActionName("Delete")]
        public async Task<ActionResult<ResponseDto>> Delete(int id)
        {


            var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
            //if (roles == null || roles.Count == 0 || email == null)
            //{
            //    _responseDto.Message = "invalid token";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}
            //if (!roles.Contains("ADMIN"))
            //{
            //    _responseDto.Message = "unauthorized";
            //    _responseDto.IsSuccess = false;
            //    return _responseDto;
            //}
            try
            {
                Architect? company = _appDbContext.Architects.FirstOrDefault(_ => _.ArchitectId == id);
                if (company == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.Architects.Remove(company);
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
