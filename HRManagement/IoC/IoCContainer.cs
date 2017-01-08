using System;
using Microsoft.Practices.Unity;

namespace HRManagement.IoC
{
    public class IoCContainer
    {
        public static Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() => new UnityContainer());

        public static IUnityContainer Instance = Container.Value;
    }
}