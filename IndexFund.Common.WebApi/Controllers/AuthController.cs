using AutoMapper;
using IndexFund.Common.WebApi.Entities;
using IndexFund.Common.WebApi.Models;
using IndexFund.Common.WebApi.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace IndexFund.Common.WebApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository authRepository;
        private readonly IMapper mapper;
        private readonly IPasswordHasher<User> passwordHasher;

        public AuthController(IAuthRepository authRepository, IMapper mapper, IPasswordHasher<User> passwordHasher)
        {
            this.authRepository = authRepository ?? throw new ArgumentNullException(nameof(authRepository));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.passwordHasher = passwordHasher ?? throw new ArgumentNullException(nameof(passwordHasher));
        }

        [HttpPost("Register")]
        public ActionResult RegisterUser([FromBody] FundUserForRegistrationDTO registerUserDTO)
        {
            var user = mapper.Map<User>(registerUserDTO);
            user.PasswordHash = passwordHasher.HashPassword(user, registerUserDTO.Password);

            return authRepository.RegisterUser(user) ? NoContent() : BadRequest("One or more validation errors occurred.");
        }

        [HttpPost("login")]
        public ActionResult LoginUser([FromBody] FundUserCreditensialsDTO userCreditensialsDTO)
        {
            string token = authRepository.ValidateUserCreditensials(userCreditensialsDTO);

            if (token.IsNullOrEmpty())
            {
                return Unauthorized("Incorrect email or password");
            }

            return Ok(token);
        }
    }
}