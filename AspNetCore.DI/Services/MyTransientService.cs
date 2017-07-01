using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DI.Services
{
    public class MyTransientService : IMyTransientService
    {
        public Guid Id { get; set; }

        public MyTransientService()
        {
            Id = Guid.NewGuid();
        }
    }
}
