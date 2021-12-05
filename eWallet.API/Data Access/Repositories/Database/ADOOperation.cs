using System.Data.SqlClient;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public class ADOOperation : IADOOperations
    {
        private readonly string _constr;
        private readonly SqlConnection _coon;
    }
}
