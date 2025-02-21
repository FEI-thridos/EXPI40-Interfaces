using System;

namespace ExpiCore
{
    public interface IOpcUaNode
    {
        string NodeId { get; }
        object Value { get; set; }
        DateTime TimeStamp { get; set; }
        bool IsVariableCategory { get; }
    }
}
