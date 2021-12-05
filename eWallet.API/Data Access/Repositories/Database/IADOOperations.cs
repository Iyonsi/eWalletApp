using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public interface IADOOperations
    {
        Task<bool> ExecuteForQuery(string stmt);
        Task<bool> ExecuteForTransactionQuery(string stmt, string stmt2);
    }
}
