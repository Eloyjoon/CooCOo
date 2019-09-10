using CooCoo.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Body
{
    internal class BodyConcrete:IBody
    {
        public BodyConcrete(IBrain brain, IEar ear, IMouth mouth)
        {
            Ear = ear;

            Mouth = mouth;

            Brain = brain;
            brain.LoadDataIntoMemory();
        }

        public IBrain Brain { get; }
        public IEar Ear { get; }
        public IMouth Mouth { get; }
    }
}
