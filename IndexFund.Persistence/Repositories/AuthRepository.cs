using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace IndexFund.Persistence.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly FundDbContext fundDbContext;
        private readonly IPasswordHasher<User> passwordHasher;
        private readonly IConfiguration configuration;

        public AuthRepository(FundDbContext fundDbContext, IPasswordHasher<User> passwordHasher, IConfiguration configuration)
        {
            this.fundDbContext = fundDbContext ?? throw new ArgumentNullException(nameof(fundDbContext));
            this.passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
            this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public bool SaveChanges() => fundDbContext.SaveChanges() >= 0;

        public bool RegisterUser(User userToCreate)
        {
            if (CheckIfUserExgists(userToCreate))
            {
                return false;
            }

            var user = fundDbContext.Add(userToCreate);
            fundDbContext.SaveChanges();

            return true;
        }
        public string ValidateUserCreditensials(FundUserCreditensialsDTO userCreditensialsDTO)
        {
            var user = fundDbContext.Users
                .Include(u => u.Role)
                .FirstOrDefault(u => u.Email == userCreditensialsDTO.Email);

            if (user == null)
            {
                return string.Empty;
            }

            var result = passwordHasher.VerifyHashedPassword(user, user.PasswordHash, userCreditensialsDTO.Password);

            if (result == PasswordVerificationResult.Failed)
            {
                return string.Empty;
            }

            var claimsForToken = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim("given_name", user.Firstname),
                new Claim("family_name", user.LastName),
                new Claim(ClaimTypes.Role, user.Role.Name)
            };

            var securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Authentication:SecretForKey"]));
            var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: configuration["Authentication:Issuer"],
                audience: configuration["Authentication:Audience"],
                claims: claimsForToken,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: signingCredentials);

            var tokenToReturn = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);

            return tokenToReturn;
        }

        private bool CheckIfUserExgists(User userTocCheck)
        {
            return fundDbContext.Users.Any(u => u.Email == userTocCheck.Email);
        }
    }
}