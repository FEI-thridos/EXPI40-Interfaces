using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpiCore
{
    public interface IReadItemChild
    {
        IReadItem Parent { get; }
    }
}
