using eWallet.APIModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public interface IUserRepository : ICRUDRepo
    {
        Task<List<User>> GetUsers();
        //Task<bool> AddUserAsync(string firstName, string lastName, string email, string phoneNumber, string github);
        Task<User> GetUserByEmail(string email);
        //Task<List<User>> ReadAllUsersAsync();
        //Task<List<User>> ReadUserAsync(string id);
       // void UpdateUser(string id, string firstName, string lastName, string email, string phoneNumber, string github);
        //Task<bool> DeleteUserAsync(string id);
       // int RowCount();
    }
}
