using Unity;
using Unity.Lifetime;
using TelecomLogic.Interfaces;
using TelecomLogic.StorageInterfaces;
using TelecomLogic.Logic;
using TelecomDB.Implement;

namespace TelecomView
{
    internal static class Program
    {
        private static IUnityContainer container = null;
        public static IUnityContainer Container { get { if (container == null) { container = BuildUnityContainer(); } return container; } }

        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<FormMain>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IClientStorage, ClientStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IServiceStorage, ServiceStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITariffStorage, TariffStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientLogic, ClientLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IServiceLogic, ServiceLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<ITariffLogic, TariffLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}