﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session.API.Services
{
    public interface IFormService
    {
        Task<bool> Exists(int id);
    }
}
