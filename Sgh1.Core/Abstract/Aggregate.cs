using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Core.Abstract
{
    public abstract class Aggregate: Entity, IAggregate
    {
        public readonly IEventDispatcher _eventDispatcher;
        public Aggregate(IEventDispatcher eventDispatcher)
        {
            _eventDispatcher = eventDispatcher;
        }

        public ICollection<IEvent> Events { get; }
        public abstract void DispatchEvents();
    }
}
