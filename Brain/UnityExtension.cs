using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooCoo.Parts;
using Unity;
using Unity.Extension;

namespace Brain
{
    public class UnityExtension: UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IBrain, BrainConcrete>();
            Container.RegisterType<IMemory, MemoryConcrete>();

        }
    }
}
