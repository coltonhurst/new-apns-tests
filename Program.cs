/*
    This is a C# example utilizing the CorePush NuGet package to send iOS push notifications.

    You can find the NuGet package here: https://github.com/andrei-m-code/net-core-push-notifications
*/

using System;
using System.Net.Http;
using System.Threading.Tasks;
using CorePush.Apple;

namespace new_apns_tests
{
    class Program
    {
        // HttpClient is intended to be instantiated once per application (not per-use)
        static readonly HttpClient client = new HttpClient();

        // Starting point, notice Main is async
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Console.WriteLine("Building ApnSettings...");

            var settings = new ApnSettings {
                P8PrivateKey = "",                      // p8 certificate generated in itunes. Just 1 line string without spaces, ----- or line breaks
                P8PrivateKeyId = "",                    // 10 digit p8 certificate id. Usually a part of a downloadable certificate filename e.g. AuthKey_IDOFYOURCR.p8
                TeamId = "",                            // Apple 10 digit team id from itunes
                AppBundleIdentifier = "",               // App slug / bundle name e.g.com.mycompany.myapp
                ServerType = ApnServerType.Development  // Development or Production APN server
            };

            var apn = new ApnSender(settings, client);

            //await apn.SendAsync(notification, deviceToken);
        }
    }
}
