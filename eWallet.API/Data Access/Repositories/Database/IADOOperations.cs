using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public interface IADOOperation
    {
        Task<bool> ExecuteForQuery(string stmt);
        Task<bool> ExecuteForTransactionQuery(string stmt, string stmt2);
    }
}
