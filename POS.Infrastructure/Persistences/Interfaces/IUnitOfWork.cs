﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaración o matrícula de nuestras interfaces a nivel del repository
        ICategoryRepository Category { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
