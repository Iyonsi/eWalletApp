using eWallet.APIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWallet.API.Controllers
{
    public interface IJWTService
    {
        Task<string> GenerateToken(User user);
    }
}
