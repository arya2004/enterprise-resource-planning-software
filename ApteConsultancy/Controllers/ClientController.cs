using ApteConsultancy.Data;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Dto;
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
    public class ClientController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public ClientController(AppDbContext appDbContext, IMapper mapper)
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

            List<Client> Clients = _appDbContext.Clients.ToList();
            _responseDto.Result = Clients;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpGet("GetOne")]

        public async Task<ActionResult<ResponseDto>> Get(int? id)
        {
            //var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            //var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
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

            Client? Clients = await _appDbContext.Clients.FirstOrDefaultAsync(_ => _.ClientId == id);
            _responseDto.Result = Clients;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }



        [HttpPost]
        public async Task<ActionResult<ResponseDto>> Create([FromBody] ClientDto Client)
        {

            //var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            //var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
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

            Client ClientToSave = _mapper.Map<Client>(Client);
            try
            {
                _appDbContext.Clients.Add(ClientToSave);
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
        public async Task<ActionResult<ResponseDto>> Edit(Client Client)
        {
            //var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            //var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
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
                _appDbContext.Clients.Update(Client);
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
        public async Task<ActionResult<ResponseDto>> Delete(int? id)
        {


            //var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            //var roles = HttpContext.User.FindAll(ClaimTypes.Role)?.Select(c => c.Value).ToList();
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
                Client? company = _appDbContext.Clients.FirstOrDefault(_ => _.ClientId == id);
                if (company == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.Clients.Remove(company);
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
