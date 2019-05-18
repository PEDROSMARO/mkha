using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sharedlib;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;

namespace ServerRemote
{
    class ServerStart
    {

        static void Main(string[] args)
        {

            HttpChannel chnl = new HttpChannel(1234);
            ChannelServices.RegisterChannel(chnl, false);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(papmanger),"papmanger.soap",WellKnownObjectMode.Singleton);


            RemotingConfiguration.RegisterWellKnownServiceType(typeof(journalservice), "journalservice.soap", WellKnownObjectMode.Singleton);

           Console.WriteLine("SERVER START "  + DateTime.Now);
           Console.ReadLine();



        }


    }
}
