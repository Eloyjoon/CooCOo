using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CooCoo.Parts
{
    public interface IBody
    {
        IBrain Brain { get; }
        IEar Ear { get; }
        IMouth Mouth { get; }
    }
}
