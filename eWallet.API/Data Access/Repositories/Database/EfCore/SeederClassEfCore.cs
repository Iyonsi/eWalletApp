using eWallet.API.EfCore_Models;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace eWallet.API.Data_Access.Repositories.Database.EfCore
{
    public class SeederClassEfCore
    {
        private readonly EwalletDbContext _ctx;
        private readonly UserManager<AppUser> _usmgr;
        private readonly RoleManager<IdentityRole> _rmgr;
        public SeederClassEfCore(EwalletDbContext ctx, UserManager<AppUser> usmgr, RoleManager<IdentityRole> rmgr)
        {
            _ctx = ctx;
            _rmgr = rmgr;
            _usmgr = usmgr;
        }

        public async Task SeedMe()
        {
            _ctx.Database.EnsureCreated();
            try
            {

                var roles = new string[] { "Admin", "Elite", "Noob" };
                if (!_rmgr.Roles.Any())
                {
                    foreach (var role in roles)
                    {
                        await _rmgr.CreateAsync(new IdentityRole(role));
                    }
                }
                var data = System.IO.File.ReadAllText("Data/EFCore/SeedData.json");
                var listOfAppUsers = JsonConvert.DeserializeObject<List<AppUser>>(data);
                if (_usmgr.Users.Count() < listOfAppUsers.Count())
                {
                    var role = roles[0];
                    var counter = 0;
                    foreach (var user in listOfAppUsers)
                    {
                        user.UserName = user.Email;
                        if (counter < 1)
                        {
                            role = roles[0];
                        }
                        else if (counter % 2 == 0)
                        {
                            role = roles[1];
                        }
                        else
                        {
                            role = roles[2];
                        }

                        var result = await _usmgr.CreateAsync(user, "P@ssw0rd");
                        if (result.Succeeded)
                            await _usmgr.AddToRoleAsync(user, role);

                        counter++;
                    }
                }
            }
            catch (DbException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
