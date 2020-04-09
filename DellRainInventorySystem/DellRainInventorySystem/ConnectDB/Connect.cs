using System.Configuration;

namespace DellRainInventorySystem.ConnectDB
{
    internal class Connect
    {
        public static string MainConn { get; } =
            ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
    }
}