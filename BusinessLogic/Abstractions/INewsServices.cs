﻿using BusinessLogic.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface INewsServices
    {
        Task<ServiceResponse> GetNews();
    }
}
