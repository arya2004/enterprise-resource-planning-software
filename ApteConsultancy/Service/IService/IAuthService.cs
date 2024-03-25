using ApteConsultancy.Dto;
using ApteConsultancy.Dto.AuthDto;

namespace ApteConsultancy.Service.IService
{
    public interface IAuthService
    {
        Task<string> Register(RegisterRequestDto requestDto);
        Task<string> RegisterEmployee(EmployeeRegisterRequestDto requestDto);
        Task<string> RegisterAssociate(AssociateRegisterRequestDto requestDto);
        Task<UserDto> Login(LoginRequestDto requestDto);
        Task<bool> AssignRole(string email, string roleName);
    }
}
