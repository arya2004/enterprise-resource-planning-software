using ApteConsultancy.Data;
using ApteConsultancy.Dto;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Models.Master;
using ApteConsultancyWEB.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public WorkOrderController(AppDbContext appDbContext, IMapper mapper)
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

            List<AssociateWorkerOrders> companies = _appDbContext.AssociateWorkerOrders.ToList();
            _responseDto.Result = companies;
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

            AssociateWorkerOrders? companies = await _appDbContext.AssociateWorkerOrders.FirstOrDefaultAsync(_ => _.AssociateWorkerOrdersId == id);
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

            AssociateWorkerOrders companyToSave = _mapper.Map<AssociateWorkerOrders>(company);
            try
            {
                _appDbContext.AssociateWorkerOrders.Add(companyToSave);
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
        public async Task<IActionResult> Edit(AssociateWorkerOrders company)
        {

            try
            {
                _appDbContext.AssociateWorkerOrders.Update(company);
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
                AssociateWorkerOrders? company = _appDbContext.AssociateWorkerOrders.FirstOrDefault(_ => _.AssociateWorkerOrdersId == id);
                if (company == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.AssociateWorkerOrders.Remove(company);
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
