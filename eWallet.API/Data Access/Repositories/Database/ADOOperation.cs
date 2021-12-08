using eWallet.API.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public  class ADOOperation : IADOOperations
    {
        private readonly string _constr;
        private SqlCommand _cmd;
        private readonly SqlConnection _conn;
        private readonly IConfiguration _configuration;

        public ADOOperation(IConfiguration configuration)
        {
            _configuration = configuration;
            _constr = configuration.GetSection("ConnectionStrings:Default").Value;

            try
            {
                _conn = new SqlConnection(_constr);
            }
            catch (DbException dbExc)
            {

                throw new Exception(dbExc.Message);
            }
           
        }

        public async Task<List<ExecuterReaderResult>> ExecuteForReader(string stmt, params string[] fields)
        {
            if (_conn == null)
                throw new Exception("Connection not established!");

            var listOfRows = new List<ExecuterReaderResult>();
            var row = new ExecuterReaderResult();

            try
            {
                using (var cmd = new SqlCommand(stmt, _conn))
                {
                    _conn.Open();
                    var res = await cmd.ExecuteReaderAsync();

                    while (res.HasRows)
                    {
                        while (res.Read())
                        {
                            foreach (var field in fields)
                            {
                                row.Fields.Add(field);
                                row.Values.Add(res[field].ToString());
                            }
                            listOfRows.Add(row);

                        }

                        await res.NextResultAsync();
                    }
                }
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return listOfRows;
        }

        public async Task<bool> ExecuteForQuery(string stmt)
        {
            if (_conn == null)   
                 throw new Exception("Connection not established!");

            var resStatus = 0;

            try
            {
                _conn.Open();

                using (var cmd = new SqlCommand(stmt, _conn))
                {
                    resStatus = await cmd.ExecuteNonQueryAsync();

                    if (resStatus < 1)
                        return false;
                }

            }
            catch (DbException dbEx)
            {
                throw new Exception(dbEx.Message);
            }
            finally
            {
                _conn.Close();
            }

            return true;
        }

        public async Task<bool> ExecuteForTransactionQuery(string stmt, string stmt2)
        {
            if (_conn == null)
                throw new Exception("Connection not established!");

            bool transState = false;

            SqlTransaction trans = null;
            try
            {
                _conn.Open();
                trans = _conn.BeginTransaction();
                using (var cmd = new SqlCommand(stmt, _conn))
                {
                    cmd.Transaction = trans;

                    // execute my first statment
                    await cmd.ExecuteNonQueryAsync();

                    // execute second query
                    cmd.CommandText = stmt2;
                    await cmd.ExecuteNonQueryAsync();

                    trans.Commit();
                    transState = true;
                }

            }
            catch (DbException ex)
            {
                await trans.RollbackAsync();
                throw new Exception(ex.Message);
            }
            finally
            {
                trans.Dispose();
                _conn.Close();
            }

            return transState;
        }

        public async Task<bool> ExecuteForNonQueryProcedure(string procedureName, params SqlParameter[] parameters)
        {
            
            int status = 0;

            if (_conn == null) throw new Exception("Failed to connect");

            try
            {
                using (_cmd = _conn.CreateCommand())
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.CommandText = procedureName;

                    if (parameters != null)
                    {
                        _cmd.Parameters.AddRange(parameters);
                    }
                    _conn.Open();
                    status = await _cmd.ExecuteNonQueryAsync();
                    if (status < 1) return false;
                }
                return true;
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        public async Task<string> ExecuteForScalar(string procedureName, params SqlParameter[] parameters)
        {
            GetConnection();
            string result = string.Empty;

            if (_newCon == null) throw new Exception("Failed to connect");

            try
            {
                using (_cmd = _newCon.CreateCommand())
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.CommandText = procedureName;

                    if (parameters != null)
                    {
                        _cmd.Parameters.AddRange(parameters);
                    }
                    _newCon.Open();
                    var ret = await _cmd.ExecuteScalarAsync();
                    _cmd.Parameters.Clear();
                    if (ret != null) result = Convert.ToString(ret);
                }
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _newCon.Close();
            }
            return result;
        }
    }
}
