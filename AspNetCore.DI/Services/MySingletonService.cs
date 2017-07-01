using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DI.Services
{
    public class MySingletonService : IMySingeltonService
    {
        public Guid Id { get; set; }

        public MySingletonService()
        {
            Id = Guid.NewGuid();
        }
    }
}
