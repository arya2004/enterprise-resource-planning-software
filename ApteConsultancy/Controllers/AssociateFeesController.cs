using ApteConsultancy.Data;
using ApteConsultancy.Dto.DropdownDto;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Dto;
using ApteConsultancy.Models.Master;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ApteConsultancy.Models;
using Microsoft.EntityFrameworkCore;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssociateFeesController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public AssociateFeesController(AppDbContext appDbContext, IMapper mapper)
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

            List<Associate_Fee> associate_fees = _appDbContext.Associate_Fees.ToList();
            _responseDto.Result = associate_fees;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

      



        [HttpGet("GetOne")]

        public async Task<ActionResult<ResponseDto>> Get(int id)
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

            Associate_Fee? companies = await _appDbContext.Associate_Fees.FirstOrDefaultAsync(_ => _.Associate_FeeId == id);
            _responseDto.Result = companies;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }



        [HttpPost]
        public async Task<ActionResult<ResponseDto>> Create([FromBody] CompanyDto company)
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

            Associate_Fee companyToSave = _mapper.Map<Associate_Fee>(company);
            try
            {
                _appDbContext.Associate_Fees.Add(companyToSave);
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
        public async Task<IActionResult> Edit(Associate_Fee company)
        {

            try
            {
                _appDbContext.Associate_Fees.Update(company);
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
                Associate_Fee? company = _appDbContext.Associate_Fees.FirstOrDefault(_ => _.Associate_FeeId == id);
                if (company == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.Associate_Fees.Remove(company);
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
