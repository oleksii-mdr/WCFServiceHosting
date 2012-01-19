using System;
using WCFClients.Client1;
using WCFClients.Client2;
using WCFClients.Client3;


namespace WCFClients
{
    class Program
    {
        static void Main(string[] args)
        {
            IService1 client1 = new Service1Client();
            IService2 client2 = new Service2Client();
            IService3 client3 = new Service3Client();

            Console.WriteLine("Client 1 says: " + client1.DoAction1());
            Console.WriteLine("Client 2 says: " + client2.DoAction2());
            Console.WriteLine("Client 3 says: " + client3.DoAction3());

            Console.ReadLine();
        }
    }
}
