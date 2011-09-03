using System.ServiceModel;

namespace WCFServices.Interfaces
{
    [ServiceContract]
    public interface IService3
    {
        [OperationContract]
        string DoAction3();
    }
}