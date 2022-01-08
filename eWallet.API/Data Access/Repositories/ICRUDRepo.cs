using eWallet.APIModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories
{
    public interface ICRUDRepo
    {
        Task<bool> AddUser(User user, string password); // returns the Id of the user
        Task<bool> AddUserToRole(User user, string roleName); // assign role to a user
        Task<List<User>> GetUsers();
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByUserName(string userName);
        Task<User> GetUserById(string id);
        Task<List<string>> GetUserRoles(User user);
        Task<bool> UserExistAsync(string email);
        Task<bool> AssignRole(string id, string[] rolesToAssign);
        Task<bool> CheckUserPassword(User user, string password);
    }
}
