using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DellRainInventorySystem.ConnectDB
{
    class Connect
    {
        public static string MainConn { get; } =
            ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
    }
}
