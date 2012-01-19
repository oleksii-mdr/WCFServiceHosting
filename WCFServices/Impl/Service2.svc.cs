using WCFServices.Interfaces;

namespace WCFServices.Impl
{
    public class Service2 : WindowsManagedService, IService2
    {
        public Service2() : base(typeof(Service2)) { }

        public string DoAction2()
        {
            return "Action 2";
        }
    }
}
