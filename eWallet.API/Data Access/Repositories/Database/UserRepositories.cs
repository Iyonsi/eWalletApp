using eWallet.APIModels;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System;

namespace eWallet.API.Data_Access.Repositories.Database
{
    public class UserRepositories
    {
        public class UserRepository : IUserRepository
        {
            private readonly IADOOperations _ado;
            private readonly SqlConnection _conn;
            private readonly IConfiguration _config;

            public UserRepository(IADOOperations aDOOperations, IConfiguration config)
            {
                _ado = aDOOperations;
                _conn = new SqlConnection(config.GetSection("ConnectionStrings:Default").Value);
                _config = config;
            }

            public Task<bool> Add<T>(T entity)
            {
                throw new NotImplementedException();
            }

            public async Task<List<User>> GetUsers()
            {
                if (_conn == null)
                    throw new Exception("Connection not established!");

                var listOfUsers = new List<User>();

                try
                {
                    using (var cmd = new SqlCommand($"SELECT * FROM {_config.GetSection("Tables:UserTable").Value}", _conn))
                    {
                        _conn.Open();
                        var res = await cmd.ExecuteReaderAsync();

                        while (res.HasRows)
                        {
                            while (res.Read())
                            {
                                listOfUsers.Add(new User
                                {
                                    Id = res["id"].ToString(),
                                    LastName = res["lastName"].ToString(),
                                    FirstName = res["firstName"].ToString(),
                                    Email = res["email"].ToString()
                                });
                            }

                            await res.NextResultAsync();
                        }
                    }

                    return listOfUsers;

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
        }
    }
}
