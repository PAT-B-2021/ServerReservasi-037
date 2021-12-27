using ServiceReservasi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServerReserv_037
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;
            try
            {
                hostObj = new ServiceHost(typeof(Service1));
                hostObj.Open();
                Console.WriteLine("Server is Ready");
                Console.ReadLine();
                hostObj.Close();
            }
            catch(Exception e)
            {
                hostObj = null;
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
