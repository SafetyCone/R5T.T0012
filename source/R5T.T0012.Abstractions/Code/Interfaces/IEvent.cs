using System;

namespace R5T.T0012.Abstractions
{
    public interface IEvent
    {
        Guid Identity { get; }
        DateTime OccurredUTC { get; }
        string TypeName { get; set; }
    }
}
