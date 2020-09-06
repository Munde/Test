﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Domain.UOW
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> SaveSync();
    }
}
