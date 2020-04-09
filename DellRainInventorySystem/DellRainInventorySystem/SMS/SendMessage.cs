using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Inetlab.SMPP;
using Inetlab.SMPP.Common;
using Inetlab.SMPP.Logging;

namespace DellRainInventorySystem.SMS
{
    internal class SendMessage
    {
        public static async Task SendOrderTask()
        {
            LogManager.SetLoggerFactory(new ConsoleLogFactory(LogLevel.Verbose));

            using (var client = new SmppClient())
            {
                try
                {
                    if (await client.ConnectAsync(new DnsEndPoint("smpp.server", 7777, AddressFamily.InterNetwork)))
                    {
                        var bindResp = await client.BindAsync("username", "password");

                        if (bindResp.Header.Status == CommandStatus.ESME_ROK)
                        {
                            var submitResp = await client.SubmitAsync(
                                Inetlab.SMPP.SMS.ForSubmit()
                                    .From("short code")
                                    .To("09338545538")
                                    .Coding(DataCodings.UCS2)
                                    .Text("Hello"));

                            if (submitResp.All(x => x.Header.Status == CommandStatus.ESME_ROK))
                                client.Logger.Info("Message has been sent");
                        }

                        await client.DisconnectAsync();
                    }
                }

                catch (Exception ex)
                {
                    client.Logger.Error("Failed send message", ex);
                }
            }
        }
    }
}