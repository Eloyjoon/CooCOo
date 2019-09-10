using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooCoo.Parts;
using Unity;
using Unity.Extension;

namespace Mouth
{
    public class UnityExtension : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IMouth, MouthConcrete>();
        }
    }
}
