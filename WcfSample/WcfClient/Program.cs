using System;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var service = new WcfClient.CustomService.Service1Client())
            {
                service.Open();

                var data = service.GetData(10);
                Console.WriteLine("data " + data);

                var compositeType = new CustomService.CompositeType();
                compositeType.BoolValue = true;
                compositeType.StringValue = "teste";

                var composite = service.GetDataUsingDataContract(compositeType);

                Console.ReadLine();
            }

        }
    }
}
