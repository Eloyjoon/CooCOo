using CooCoo.Parts;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Extension;

namespace CooCoo.Ear
{
    public class Extensions : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType(typeof(IEar), typeof(Ear));
        }
    }
}
