using System.ServiceProcess;

namespace WindowsServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceBase.Run(new WindowsManagedServices());
        }
    }
}
