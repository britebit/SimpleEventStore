﻿using System.Threading.Tasks;
using SimpleEventStore.InMemory;

namespace SimpleEventStore.Tests.InMemory
{
    public class InMemoryEventStoreCatchUpSubscription : EventStoreCatchUpSubscription
    {
        protected override Task<IStorageEngine> CreateStorageEngine()
        {
            return Task.FromResult((IStorageEngine)new InMemoryStorageEngine());
        }
    }
}
