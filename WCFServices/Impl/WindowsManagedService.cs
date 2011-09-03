using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFServices.Interfaces;
using System.ServiceModel;

namespace WCFServices.Impl
{
    public abstract class WindowsManagedService : IWindowsManagedService
    {
        private ServiceHost serviceHost;

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