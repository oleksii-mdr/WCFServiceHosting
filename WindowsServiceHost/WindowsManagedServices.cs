using System;
using System.Collections.Generic;
using System.ServiceProcess;
using WCFServices.Interfaces;
using System.Reflection;


namespace WindowsServiceHost
{
    public class WindowsManagedServices : ServiceBase
    {
        private readonly List<IWindowsManagedService> services;

        public WindowsManagedServices()
        {
            services = new List<IWindowsManagedService>();

            var assembly = Assembly.GetAssembly(typeof(IWindowsManagedService));
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (!type.IsAbstract && typeof(IWindowsManagedService).IsAssignableFrom(type))
                {
                    var serviceObject = (IWindowsManagedService)Activator.CreateInstance(type);
                    services.Add(serviceObject);
                }
            }
        }

        protected override void OnStart(string[] args)
        {
            foreach (var service in services)
            {
                service.Start();
            }
        }

        protected override void OnStop()
        {
            foreach (var service in services)
            {
                service.Stop();
            }
        }
    }
}
