using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using WCFServices.Interfaces;
using System.Reflection;
using System.IO;
using WCFServices.Impl;
using System.Diagnostics;

namespace WindowsServiceHost
{
    public class WindowsManagedServices : ServiceBase
    {
        private List<IWindowsManagedService> services;

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
