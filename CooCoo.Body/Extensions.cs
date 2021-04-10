using CooCoo.Parts;
using System;
using System.Collections.Generic;
using System.Text;
using Unity;
using Unity.Extension;

namespace CooCoo.Body
{
    public class Extensions : UnityContainerExtension
    {
        protected override void Initialize()
        {
            this.Container.RegisterType(typeof(IBody), typeof(Body));
        }
    }
}
