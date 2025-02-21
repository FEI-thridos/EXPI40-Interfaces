using System.Collections.Generic;

namespace ExpiCore
{
    public interface IReadItem
    {
        List<IOpcUaNode> Nodes { get; set; }
    }
}
