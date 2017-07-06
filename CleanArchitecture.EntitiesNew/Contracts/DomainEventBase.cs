using System;

namespace CleanArchitecture.Entities.Contracts
{
    public abstract class DomainEventBase
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
