using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DI.Services
{
    public interface IMyService
    { 
        Guid Id { get; set; }
    }

    public interface IMySingeltonService : IMyService
    {

    }

    public interface IMyTransientService : IMyService
    {

    }
        
    public interface IMyScopedService : IMyService
    {

    }

}
