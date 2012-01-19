using WCFServices.Interfaces;

namespace WCFServices.Impl
{
    public class Service3 : WindowsManagedService, IService3
    {
        public Service3() : base(typeof(Service3)) { }

        public string DoAction3()
        {
            return "Action 3";
        }
    }
}
