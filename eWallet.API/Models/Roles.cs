﻿using System;

namespace eWallet.API.Models
{
    public class Roles
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string RoleName { get; set; }
    }
}
