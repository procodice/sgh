using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Core.Abstract
{
    public interface IEventDispatcher
    {
        ICollection<IEventHandler<IEvent>> Handlers { get; }
        ICollection<IEvent> EventsToDispatch { get; }

        void DispatchEvents();

        public void AddHandler(IEventHandler<IEvent> eh);
        public void AddEvent(IEvent e);
    }
}
