using System;
using System.Collections.Generic;
using System.Text;

namespace Sgh1.Core.Abstract
{
    public interface IEvent
    {
        string Name { get; }
        object Content { get;}
    }
}
