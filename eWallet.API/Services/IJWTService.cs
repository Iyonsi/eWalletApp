using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eWallet.API.Controllers
{
        public interface IJWTService
        {
            public string GenerateToken();
        }
}
