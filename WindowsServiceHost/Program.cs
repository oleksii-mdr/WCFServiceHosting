using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
