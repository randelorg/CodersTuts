using System.Configuration;

namespace DellRainInventorySystem.ConnectDB
{
    class Connect
    {
        public static string MainConn { get; } =
            ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
    }
}
