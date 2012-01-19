using System;
using WCFServices.Interfaces;
using System.ServiceModel;

namespace WCFServices.Impl
{
    public abstract class WindowsManagedService : IWindowsManagedService
    {
        private readonly ServiceHost serviceHost;

        protected WindowsManagedService(Type serviceType)
        {
            serviceHost = new ServiceHost(serviceType);
        }

        public void Start()
        {
            serviceHost.Open();
        }

        public void Stop()
        {
            serviceHost.Close();
        }
    }
}