﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Actio.Common.Commands
{
    public class CreateUser : IAuthenticatedComman
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }
        public Guid UserId { get; set; }
    }
}
