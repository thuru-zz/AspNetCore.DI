using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.DI.Services
{
    public class MyAnotherService : IMyAnotherService
    {
        private readonly IMySingeltonService _singletonService;
        private readonly IMyTransientService _transientService;
        private readonly IMyScopedService _scopedService;

        public Guid SingletonId { get; set; }
        public Guid TransientId { get; set; }
        public Guid ScopedId { get; set; }

        public MyAnotherService(IMySingeltonService singletom, IMyTransientService transient, IMyScopedService scoped)
        {
            _singletonService = singletom;
            _transientService = transient;
            _scopedService = scoped;

            SingletonId = singletom.Id;
            TransientId = transient.Id;
            ScopedId = scoped.Id;
        }
    }
}
