using ApteConsultancy.Model.Master;

namespace ApteConsultancy.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser application, IEnumerable<string> roles);
    }
}
