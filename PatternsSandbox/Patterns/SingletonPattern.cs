using System;

namespace PatternsSandbox.Patterns
{
    class SingletonPattern : IPattern
    {
        public void RunExample()
        {
            Console.WriteLine("Creating webserver...");

            WebServer server1 = WebServer.Instance();
            server1.DomainName = "jimrules.com";
            server1.Port = 80;

            server1.ShowStatus("ServerInstance1");

            Console.WriteLine("Spawning 2nd webserver object from Singleton object...");

            WebServer server2 = WebServer.Instance();
            server2.ShowStatus("ServerInstance2");
        }
    }

    class WebServer
    {
        private static WebServer _server;

        public string DomainName { get; set; }
        public int Port { get; set; }

        private WebServer()
        {
            
        }

        public static WebServer Instance()
        {
            return _server ?? (_server = new WebServer());
        }

        public void ShowStatus(string identifier)
        {
            Console.WriteLine("{0} is currently hosting {1} on port {2}.", identifier, DomainName, Port);
        }
    }
}
