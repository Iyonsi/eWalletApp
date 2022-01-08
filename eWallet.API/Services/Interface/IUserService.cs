using eWallet.API.DTOs;
using eWallet.APIModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWallet.API.Services
{
    public interface IUserService
    {
        public List<User> Users { get; }
        Task<RegisterSuccessDto> Register(User user, string password);
        Task<LoginSuccess> Login(string email, string password);
        Task<User> GetUser(string email);
    }
}
