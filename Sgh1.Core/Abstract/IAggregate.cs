using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Core.Abstract
{
    public interface IAggregate
    {
        ICollection<IEvent> Events { get; }
        void DispatchEvents();
    }
}
