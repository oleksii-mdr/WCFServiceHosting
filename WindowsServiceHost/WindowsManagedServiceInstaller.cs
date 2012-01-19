using System.Configuration.Install;
using System.ComponentModel;
using System.ServiceProcess;

namespace WindowsServiceHost
{
    [RunInstaller(true)]
    public class WindowsManagedServiceInstaller : Installer
    {
        private readonly ServiceProcessInstaller process;
        private readonly ServiceInstaller service;

        public WindowsManagedServiceInstaller()
        {
            process = new ServiceProcessInstaller();
            process.Account = ServiceAccount.LocalSystem;
            
            service = new ServiceInstaller();
            service.ServiceName = "WCFServices";
            service.StartType = ServiceStartMode.Automatic;
            service.Description = "Host multiple WCF services";
            
            Installers.Add(process);
            Installers.Add(service);
        }
    }
}
