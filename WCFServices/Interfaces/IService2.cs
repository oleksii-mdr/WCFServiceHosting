using System.ServiceModel;

namespace WCFServices.Interfaces
{
    [ServiceContract]
    public interface IService2
    {
        [OperationContract]
        string DoAction2();
    }
}