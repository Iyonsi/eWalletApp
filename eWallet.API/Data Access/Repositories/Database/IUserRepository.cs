using eWallet.APIModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public interface IUserRepository : ICRUDRepo
    {
        Task<List<User>> GetUsers();
    }
}
