using System.ServiceModel;

namespace WCFServices.Interfaces
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string DoAction1();
    }
}