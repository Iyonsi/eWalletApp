using eWallet.API.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public interface IADOOperations
    {
        Task<bool> ExecuteForQuery(string stmt);
        Task<bool> ExecuteForTransactionQuery(string stmt, string stmt2);
        Task<List<ExecuterReaderResult>> ExecuteForReader(string stmt, params string[] fields);
        Task<string> ExecuteForScalar(string procedureName, params SqlParameter[] paramters);
        Task<bool> ExecuteForNonQueryProcedure(string procedureName, params SqlParameter[] parameters);
        Task<TData> Reader<TData>(string procedureName, string FieldName);
        Task<List<ExecuterReaderResult>> ExecuteForReaderProcedure(string procedureName, params string[] fields);
    }
}
