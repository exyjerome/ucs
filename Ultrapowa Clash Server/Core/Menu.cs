using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using UCS.PacketProcessing;

namespace UCS.Core
{
    class Menu
    {
        public Menu()
        {
            while (true)
            {
                Console.WriteLine("");
                string line = Console.ReadLine();
                if (line == "/shutdown")
                {
                    System.Environment.Exit(1);
                }
                else if (line == "/clear")
                {
                    Console.Clear();
                }
                else if (line == "/op")
                {
                    Console.WriteLine("Op Command Process, ID of Player : ");
                    string id = Console.ReadLine();
                }
                else if (line == "/status")
                {
                    string hostName = Dns.GetHostName();
                    string IPM = Dns.GetHostByName(hostName).AddressList[0].ToString();
                    Console.WriteLine("Server IP : " + IPM + " on port 9339");
                    Console.WriteLine("DebugMode Link : ");
                    Console.WriteLine("Players Online : " + ResourcesManager.GetOnlinePlayers().Count);
                    Console.WriteLine("Starting Gems : " + Int32.Parse(ConfigurationManager.AppSettings["StartingGems"]));
                    Console.WriteLine("CoC Version : " + ConfigurationManager.AppSettings["ClientVersion"]);
                    if (Convert.ToBoolean(ConfigurationManager.AppSettings["useCustomPatch"]))
                    {
                        string patchserver = "Yes";
                        Console.WriteLine("Patch : " + patchserver);
                        Console.WriteLine("Patching Server : " + ConfigurationManager.AppSettings["patchingServer"]);
                    }
                    else
                    {
                        string patchserver = "No";
                        Console.WriteLine("Patch : " + patchserver);
                    }
                }
                else if (line == "/help")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Available commands :");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("/op - This commands set privileges to a specific user.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("/shutdown - This commands fully close the server without message.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("/status - This commands show informations about the server.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("/clear - Clean the emulator screen");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("/help - This commands show a list of available commands.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Available commands :");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("/op - This commands set privileges to a specific user.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("/shutdown - This commands fully close the server without message.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("/status - This commands show informations about the server.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("/clear - Clean the emulator screen");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("/help - This commands show a list of available commands.");
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
        

