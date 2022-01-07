using eWallet.API.Controllers;
using eWallet.API.Data_Access.Repositories.Database;
using eWallet.APIModels;
using Microsoft.AspNetCore.Identity;

namespace eWallet.API.Services.Implementations
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly UserManager<User> _userManager;
        private readonly IJWTService _jwtService;

        public AuthService(IUserRepository userRepository, UserManager<User> userManager, IJWTService jwtService)
        {
            _userRepository = userRepository;
            _userManager = userManager;
            _jwtService = jwtService;
            
        }

        public async Task<ResponseDto<string>> Login (string email, string password)
        {
            ResponseDto<string> response = new ResponseDto<string>();

            User extinguisher  = await _userRepository.GetUserByEmail(email);
            var isCorrect = await _userRepository.CheckUserPassword(extinguisher)
        }
    }
}
