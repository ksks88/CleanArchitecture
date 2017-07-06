using System.Collections.Generic;

namespace CleanArchitecture.Entities.Contracts
{
   
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public IList<DomainEventBase> Events = new List<DomainEventBase>();
    }
}
