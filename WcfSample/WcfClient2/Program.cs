using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfSample;

namespace WcfClient2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var channel = new ChannelFactory<IService1>(new BasicHttpBinding(), "http://localhost:54896/Service1.svc"))
            {
                channel.Open();

                var service = channel.CreateChannel();

                var resultado = service.GetData(11);

                Console.WriteLine(resultado);
            }

            Console.ReadLine();
        }
    }
}
