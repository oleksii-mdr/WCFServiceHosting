using System;
using WCFServices.Interfaces;

namespace WCFServices.Impl
{
    public class Service1 : WindowsManagedService, IService1
    {
        public Service1() : base(typeof(Service1)) { }

        public string DoAction1()
        {
            return "Action 1";
        }
    }
}
