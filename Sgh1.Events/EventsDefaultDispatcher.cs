using Sgh1.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Events
{
    //tu powinien byc uzyty mechanizm refleksji
    public class EventsDefaultDispatcher : IEventDispatcher
    {
        public EventsDefaultDispatcher()
        {
            _handlers = new List<IEventHandler<IEvent>>();
            _eventsToDispatch = new List<IEvent>();
        }
        private ICollection<IEventHandler<IEvent>> _handlers;
        private ICollection<IEvent> _eventsToDispatch;
        public ICollection<IEventHandler<IEvent>> Handlers { get => _handlers; private set { _handlers = value; } }
        public ICollection<IEvent> EventsToDispatch { get => _eventsToDispatch; private set { _eventsToDispatch = value; } }

        public void AddHandler(IEventHandler<IEvent> eh)
        {
            _handlers.Add(eh);
        }
        public void AddEvent(IEvent e)
        {
            _eventsToDispatch.Add(e);
        }
        public void DispatchEvents()
        {
            var dispatched = new List<IEvent>();
            foreach(var e in _eventsToDispatch)
            {
                foreach(var eh in  _handlers)
                {
                    if(eh.EventName.Equals(e.Name))
                    {
                        eh.Handle(e);
                        dispatched.Add(e);
                        break;
                    }
                }
            }

            if (dispatched.Count == _eventsToDispatch.Count)
                _eventsToDispatch.Clear();
            else
                throw new Exception("Nie udalo sie obsluzyc wszystkich zdarzen");
        }
    }
}
