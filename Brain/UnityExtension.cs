using CooCoo.Parts;
using Unity;
using Unity.Extension;
using Unity.Lifetime;

namespace Brain
{
    public class UnityExtension: UnityContainerExtension
    {
        protected override void Initialize()
        {
            Container.RegisterType<IBrain, BrainConcrete>();
            Container.RegisterType<IMemory, MemoryConcrete>(new SingletonLifetimeManager());
        }
    }
}
