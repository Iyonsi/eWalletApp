using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eWallet.API.Controllers
{
    public class JWTService : IJWTService
    {
        public string GenerateToken()
        {
            var claims = new List<Claim>();
            var claim = new Claim(ClaimTypes.NameIdentifier, "Israel");
            claims.Add(claim);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("JWT:SecurityKey"));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature),
                Expires = DateTime.Now.AddDays(1)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenValue = tokenHandler.WriteToken(token);

            return tokenValue;
        }
    }
}
