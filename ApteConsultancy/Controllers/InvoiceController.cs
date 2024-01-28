using ApteConsultancy.Data;
using ApteConsultancy.Dto.MasterDto;
using ApteConsultancy.Dto;
using ApteConsultancy.Models.Master;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using ApteConsultancy.Models;
using Microsoft.EntityFrameworkCore;
using ApteConsultancy.Dto.AdminDto;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GSTInvoiceController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        private ResponseDto _responseDto;
        private IMapper _mapper;

        public GSTInvoiceController(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _responseDto = new ResponseDto();
            _mapper = mapper;
        }
        [HttpGet("GetAllGST")]
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

            List<GSTInvoice> GSTInvoices = _appDbContext.GSTInvoices.Include(_ => _.Project).ToList();
            _responseDto.Result = GSTInvoices;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpGet("GetOneGST")]

        public async Task<ActionResult<ResponseDto>> Get(string? number)
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

            GSTInvoice? GSTInvoices = await _appDbContext.GSTInvoices.Include(_ => _.Project).FirstOrDefaultAsync(_ => _.InvoiceNumber == number);
            _responseDto.Result = GSTInvoices;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }



        [HttpPost("CreateGST")]
        public async Task<ActionResult<ResponseDto>> Create([FromBody] CreateGSTInvoiceDto GSTInvoice)
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

            GSTInvoice GSTInvoiceToSave = _mapper.Map<GSTInvoice>(GSTInvoice);
            var projects = await _appDbContext.Projects.FindAsync(GSTInvoice.ProjectId);
            GSTInvoiceToSave.Project = projects;
            try
            {
                _appDbContext.GSTInvoices.Add(GSTInvoiceToSave);
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

        [HttpPut("UpdateGST")]
        public async Task<ActionResult<ResponseDto>> Edit(GSTInvoice GSTInvoice)
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

            GSTInvoice GSTInvoiceToSave = _mapper.Map<GSTInvoice>(GSTInvoice);
            try
            {
                _appDbContext.GSTInvoices.Update(GSTInvoiceToSave);
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


        [HttpDelete("DeleteGST")]
        [ActionName("DeleteGST")]
        public async Task<ActionResult<ResponseDto>> DeleteGST(string? number)
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
                GSTInvoice? GSTInvoice = _appDbContext.GSTInvoices.FirstOrDefault(_ => _.InvoiceNumber == number);
                if (GSTInvoice == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.GSTInvoices.Remove(GSTInvoice);
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

        //Proforma
        //Proforma


        [HttpGet("GetAllProforma")]
        public ActionResult<ResponseDto> GetAllProforma()
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

            List<ProformaInvoice> ProformaInvoices = _appDbContext.ProformaInvoices.Include(_ => _.Project).ToList(); 
            _responseDto.Result = ProformaInvoices;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpGet("GetOneProforma")]

        public async Task<ActionResult<ResponseDto>> GetProforma(string? number)
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

            ProformaInvoice? ProformaInvoices = await _appDbContext.ProformaInvoices.Include(_ => _.Project).FirstOrDefaultAsync(_ => _.InvoiceNumber == number);
            _responseDto.Result = ProformaInvoices;
            _responseDto.IsSuccess = true;
            return Ok(_responseDto);

        }



        [HttpPost("CreateProforma")]
        public async Task<ActionResult<ResponseDto>> Proforma([FromBody] CreateProformaInvoiceDto ProformaInvoice)
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

            ProformaInvoice ProformaInvoiceToSave = _mapper.Map<ProformaInvoice>(ProformaInvoice);
            var projects = await _appDbContext.Projects.FindAsync(ProformaInvoice.ProjectId);
            ProformaInvoiceToSave.Project = projects;
            try
            {
                _appDbContext.ProformaInvoices.Add(ProformaInvoiceToSave);
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

        [HttpPut("UpdateProforma")]
        public async Task<ActionResult<ResponseDto>> EditProforma(GSTInvoice GSTInvoice)
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

            GSTInvoice GSTInvoiceToSave = _mapper.Map<GSTInvoice>(GSTInvoice);
            try
            {
                _appDbContext.GSTInvoices.Update(GSTInvoiceToSave);
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


        [HttpDelete("DeleteProforma")]
        [ActionName("DeleteProforma")]
        public async Task<ActionResult<ResponseDto>> DeleteProforma(string? number)
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
                ProformaInvoice? ProformaInvoice = _appDbContext.ProformaInvoices.FirstOrDefault(_ => _.InvoiceNumber == number);
                if (ProformaInvoice == null)
                {
                    _responseDto.Message = "NOt Found";
                    _responseDto.IsSuccess = false;
                    return NotFound(_responseDto);
                }
                _appDbContext.ProformaInvoices.Remove(ProformaInvoice);
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
