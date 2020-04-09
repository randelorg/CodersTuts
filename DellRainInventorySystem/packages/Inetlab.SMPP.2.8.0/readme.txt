Inetlab.SMPP Client/Server Library

TRIAL VERSION. 
===========================

The Trial version may be used for private evaluation purposes only. Developers can test the functionality of Inetlab.SMPP without paying for a license. 
The Software should not be published in any internet nor intranet project until an appropriate license is purchased. 

"[TRIAL]" will be added to the message text. This version has no time limit.

For production use you need to purchase a license at https://www.inetlab.com/Purchase.html

Documentation 
============================

(work in progress, contributions appreciated):

Please see https://docs.inetlab.com/ for more information on using Inetlab.SMPP library

Samples: 
https://www.inetlab.com/Downloading/Inetlab.SMPP.zip
or
https://gitlab.com/inetlab/smpp-samples/


HOW TO INSTALL LICENSE FILE
===========================
After purchase you will receive Inetlab.SMPP.license file per E-Mail. 
Add this file to the project where you have a reference on Inetlab.SMPP.dll. Change "Build Action" of the file to "Embedded Resource". 

Set license before using Inetlab.SMPP classes in your code:

Inetlab.SMPP.LicenseManager.SetLicense(this.GetType().Assembly.GetManifestResourceStream(this.GetType(), "Inetlab.SMPP.license" ));


Quick Sample
==========================

        public static async Task SendHelloWorld()
        {
            LogManager.SetLoggerFactory(new ConsoleLogFactory(LogLevel.Verbose));

            using (SmppClient client = new SmppClient())
            {
                try
                {
                    if (await client.ConnectAsync(new DnsEndPoint("smpp.server", 7777, AddressFamily.InterNetwork)))
                    {
                        BindResp bindResp = await client.BindAsync("username", "password");

                        if (bindResp.Header.Status == CommandStatus.ESME_ROK)
                        {
                            var submitResp = await client.SubmitAsync(
                                SMS.ForSubmit()
                                    .From("short code")
                                    .To("436641234567")
                                    .Coding(DataCodings.UCS2)
                                    .Text("Hello World!"));

                            if (submitResp.All(x => x.Header.Status == CommandStatus.ESME_ROK))
                            {
                                client.Logger.Info("Message has been sent.");
                            }
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
