using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DI.Services
{
    public interface IMyAnotherService
    {
        Guid SingletonId { get; set; }
        Guid TransientId { get; set; }
        Guid ScopedId { get; set; }

    }
}
