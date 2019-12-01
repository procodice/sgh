using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Core.Abstract
{
    public interface IEventHandler<T> where T: IEvent
    {
        T Event { get; }
        string EventName { get; }
        void Handle(T @event);
    }
}
