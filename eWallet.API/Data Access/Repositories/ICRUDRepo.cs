using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories
{
    public interface ICRUDRepo
    {
        Task<bool> Add<T>(T entity);
    }
}
