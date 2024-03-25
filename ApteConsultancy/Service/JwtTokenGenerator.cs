using ApteConsultancy.Model.Master;
using ApteConsultancy.Service.IService;
using ApteConsultancy.Utility;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApteConsultancy.Service
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {

        private readonly IConfiguration _configuration;
        private readonly SymmetricSecurityKey _symmetricSecurityKey;
        public JwtTokenGenerator(IConfiguration configuration)
        {
            _configuration = configuration;
            _symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtOptions:Secret"]));
        }

        public string GenerateToken(ApplicationUser user, IEnumerable<string> roles)
        {
            var claimsList = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email),

                new Claim(ClaimTypes.NameIdentifier, user.Id)

            };
            if(user.EmployeeName != null)
            {
                claimsList.Add(new Claim(ClaimTypes.GivenName, user.EmployeeName));
            }
            else
            {
                claimsList.Add(new Claim(ClaimTypes.GivenName, user.CompanyName));
            }
           
            claimsList.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var credential = new SigningCredentials(_symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claimsList),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = credential,
                Issuer = _configuration["JwtOptions:Issuer"],
                Audience = _configuration["JwtOptions:Audience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
