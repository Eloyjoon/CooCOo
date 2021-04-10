using CooCoo.Parts;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Extension;

namespace CooCoo.Memory
{
    public class Extensions : UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType(typeof(IMemory), typeof(Memory));
        }
    }
}
