using eWallet.API.DTOs;
using System.Threading.Tasks;

namespace eWallet.API.Services.Implementations
{
    public interface IAuthService
    {
        Task<ResponseDto<string>> Login(string email, string password);
    }
}