using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Configuration;
using System.Net;
using UCS.Network;
using UCS.PacketProcessing;
using UCS.Core;

namespace UCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ultrapowa Clash Server v0.6.1.2 Cannary 1X";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
@"
888     888  .d8888b.   .d8888b.  
888     888 d88P  Y88b d88P  Y88b 
888     888 888    888 Y88b.      
888     888 888         ""Y888b.   
888     888 888            ""Y88b. 
888     888 888    888       ""888 
Y88b. .d88P Y88b  d88P Y88b  d88P 
 ""Y88888P""   ""Y8888P""   ""Y8888P""  
        ");
            Console.WriteLine("Ultrapowa Clash Server");
            Console.WriteLine("version 0.6.1.5 XV");
            Console.WriteLine("www.ultrapowa.com");
            Console.WriteLine("Get support by contacting Aidid on the forum");
            Console.WriteLine("");
            Console.WriteLine("Server starting...");
            Console.ResetColor();
            Gateway g = new Gateway();
            PacketManager ph = new PacketManager();
            MessageManager dp = new MessageManager();
            ResourcesManager rm = new ResourcesManager();
            ObjectManager pm = new ObjectManager();
            dp.Start();
            ph.Start();
            g.Start();
            Debugger.SetLogLevel(Int32.Parse(ConfigurationManager.AppSettings["loggingLevel"]));
            Logger.SetLogLevel(Int32.Parse(ConfigurationManager.AppSettings["loggingLevel"]));
            string hostName = Dns.GetHostName();
            string IP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["apiManager"]))
            {
                ApiManager api = new ApiManager();
                Console.WriteLine("Server started on " + IP + ":9339 and let's play Clash of Clans!");

            }
            else
            {
                Console.WriteLine("Api Manager disable...");
                Console.WriteLine("Server started on " + IP + ":9339 and let's play Clash of Clans!");
            }
            Thread.Sleep(Timeout.Infinite);
        }
    }
}