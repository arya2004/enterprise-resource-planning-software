using ApteConsultancy.Data;
using ApteConsultancy.Dto;
using ApteConsultancy.Dto.AuthDto;
using ApteConsultancy.Model.Master;
using ApteConsultancy.Models.Master;
using ApteConsultancy.Service.IService;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ApteConsultancy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthAPIController : ControllerBase
    {


        private readonly IAuthService _authService;
        private readonly IConfiguration _configuration;
        protected ResponseDto _responseDto;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IJwtTokenGenerator _jwtService;
        private readonly AppDbContext _appDbContext;
        private IMapper _mapper;
        public AuthAPIController(IMapper mapper, AppDbContext appDbContext, IAuthService authService, IConfiguration configuration, RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager, IJwtTokenGenerator jwtService)
        {
            _authService = authService;
            _configuration = configuration;
            _responseDto = new ResponseDto();
            _roleManager = roleManager;
            _userManager = userManager;
            _jwtService = jwtService;
            _appDbContext = appDbContext;
            _mapper = mapper;

        }

        [HttpGet("")]
        public async Task<ActionResult<ResponseDto>> Persistant()
        {
            return _responseDto;

        }

        //[Authorize]
        [HttpGet("GetCurrentUser")]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;

            var user = await _userManager.FindByEmailAsync(email);

            var roles = await _userManager.GetRolesAsync(user);

            return new UserDto
            {
                Email = user.Email,
                Token = _jwtService.GenerateToken(user, roles),
                Displlayname = user.EmployeeName

            };
        }



        [HttpPost("register")]
        public async Task<ActionResult<ResponseDto>> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var Message = await _authService.Register(registerRequestDto);
            if (!string.IsNullOrEmpty(Message))
            {
                _responseDto.Message = Message;
                _responseDto.IsSuccess = false;
                return BadRequest(_responseDto);
            }
            return Ok(_responseDto);

        }


        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login([FromBody] LoginRequestDto loginRequestDto)
        {
            var Message = await _authService.Login(loginRequestDto);
            if (Message.Email == null)
            {
                _responseDto.IsSuccess = false;
                _responseDto.Message = "incorrect field";
                return BadRequest(  );
            }
            _responseDto.Result = Message;
            return Message;
        }

        [HttpPost("assign")]
        public async Task<ActionResult<ResponseDto>> Assign([FromBody] RegisterRequestDto registerRequestDto)
        {

            var result = await _authService.AssignRole(registerRequestDto.Email, registerRequestDto.Role.ToUpper());
            if (!result) _responseDto.IsSuccess = false;    
            return Ok(_responseDto);
        }

        [HttpGet("user")]
        public async Task<ActionResult<ResponseDto>> LoadCurrentUser()
        {
            //var text = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            //Console.WriteLine(text);

            //var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            //Console.WriteLine(email);
            //var email = HttpContext.User.FindFirst(ClaimTypes.Email)?.Value;
            var email = HttpContext.User?.Claims?.FirstOrDefault(x => x.Type == ClaimTypes.Email)?.Value;
            var user = await _userManager.FindByEmailAsync(email);
            var roles = await _userManager.GetRolesAsync(user);
            UserDto dt = new UserDto
            {
                Email = user.Email,
                Token = _jwtService.GenerateToken(user, roles),
                Displlayname = user.EmployeeName

            };
            _responseDto.Result = dt;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

        [HttpPost("registerEmployee")]
        public async Task<ActionResult<ResponseDto>> RegisterEmployee([FromBody] EmployeeRegisterRequestDto registerRequestDto)
        {
            var Message = await _authService.RegisterEmployee(registerRequestDto);
            if (!string.IsNullOrEmpty(Message))
            {
                _responseDto.Message = Message;
                _responseDto.IsSuccess = false;
                return BadRequest(_responseDto);
            }
            return Ok(_responseDto);

        }
        [HttpPost("registerAssociate")]
        public async Task<ActionResult<ResponseDto>> RegisterAssociate([FromBody] AssociateRegisterRequestDto registerRequestDto)
        {


            ApplicationUser user = _mapper.Map<ApplicationUser>(registerRequestDto);

            var Message = await _authService.RegisterAssociate(registerRequestDto);
            if (!string.IsNullOrEmpty(Message))
            {
                _responseDto.Message = Message;
                _responseDto.IsSuccess = false;
                return BadRequest(_responseDto);
            }
            return Ok(_responseDto);

        }

        [HttpGet("GetAll")]
        public ActionResult<ResponseDto> GetAll()
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

            List<ApplicationUser> companies = _appDbContext.ApplicationUsers.ToList();
            _responseDto.Result = companies;
            _responseDto.IsSuccess = true;
            return _responseDto;
        }

    }
}
