using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DI.Services
{
    public class MyScopedService : IMyScopedService
    {
        public Guid Id { get; set; }

        public MyScopedService()
        {
            Id = Guid.NewGuid();
        }
    }
}
