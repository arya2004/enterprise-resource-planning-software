using ApteConsultancy.Data;
using ApteConsultancy.Dto;
using ApteConsultancy.Dto.AuthDto;
using ApteConsultancy.Model.Master;
using ApteConsultancy.Models.Master;
using ApteConsultancy.Service.IService;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace ApteConsultancy.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _applicationDbContext;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IJwtTokenGenerator _jwtService;
        private readonly SignInManager<ApplicationUser> signInManager;
        private IMapper _mapper;

        public AuthService(IMapper mapper,    AppDbContext applicationDbContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IJwtTokenGenerator jwtService, SignInManager<ApplicationUser> signInManager)
        {
            _applicationDbContext = applicationDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _jwtService = jwtService;
            this.signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<bool> AssignRole(string email, string roleName)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();
                }
                await _userManager.AddToRoleAsync(user, roleName);
                return true;
            }
            return false;
        }
   

        public async Task<UserDto> Login(LoginRequestDto requestDto)
        {
            var user = await _userManager.FindByEmailAsync(requestDto.Email);

            if (user == null)
            {
                return new UserDto()
                {
                    Email = null,
                    Displlayname = null,
                    Token = ""

                };
            }
            var result = await signInManager.CheckPasswordSignInAsync(user, requestDto.Password, false);
            if (!result.Succeeded)
            {
                return new UserDto()
                {
                    Email = null,
                    Displlayname = null,
                    Token = ""

                };
            }
            var roles = await _userManager.GetRolesAsync(user);
            return new UserDto
            {
                Email = user.Email,
                Token = _jwtService.GenerateToken(user, roles),
                Displlayname = user.Email
            };
        }

        public async Task<string> Register(RegisterRequestDto requestDto)
        {
            ApplicationUser user = new()
            {
                Email = requestDto.Email,
                UserName = requestDto.Name,
                EmployeeName = requestDto.Email,
                NormalizedEmail = requestDto.Email.Normalize()

            };
            try
            {
                var result = await _userManager.CreateAsync(user, requestDto.Password);
                if (result.Succeeded)
                {

                    return "";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return "Error";
        }

        public async Task<string> RegisterAssociate(AssociateRegisterRequestDto requestDto)
        {
            ApplicationUser user = _mapper.Map<ApplicationUser>(requestDto);
            user.UserName = requestDto.Name;
            user.IsAssociate = true;
            try
            {
                var result = await _userManager.CreateAsync(user, requestDto.Password);
                if (result.Succeeded)
                {

                    
                        if (!_roleManager.RoleExistsAsync("ASSOCIATE").GetAwaiter().GetResult())
                        {
                            _roleManager.CreateAsync(new IdentityRole("ASSOCIATE")).GetAwaiter().GetResult();
                        }
                        await _userManager.AddToRoleAsync(user, "ASSOCIATE");
                        return "Registered and Assigned Role Successfully ASSOCIATE";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return "Error";
        }

        public async Task<string> RegisterEmployee(EmployeeRegisterRequestDto requestDto)
        {
            ApplicationUser user = _mapper.Map<ApplicationUser>(requestDto);
            user.UserName = requestDto.Name;
            user.IsAssociate = false;
            try
            {
                var result = await _userManager.CreateAsync(user, requestDto.Password);
                if (result.Succeeded)
                {

                    if (!_roleManager.RoleExistsAsync("EMPLOYEE").GetAwaiter().GetResult())
                    {
                        _roleManager.CreateAsync(new IdentityRole("EMPLOYEE")).GetAwaiter().GetResult();
                    }
                    await _userManager.AddToRoleAsync(user, "EMPLOYEE");
                    return "Registered and Assigned Role Successfully EMPLOYEE";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return "Error";
        }
    }
}
