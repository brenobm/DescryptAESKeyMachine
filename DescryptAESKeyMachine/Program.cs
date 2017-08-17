using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace DescryptAESKeyMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Program.Descrypt("99E86E93697A74C751AA30831F4A5B681C265B3D63DF8522692C737062A99450822296EA6466BAC604B5CDF2D2EFB1ED59F92BA009556F7E929546CA11B627DBD47E7A0FBFB05F86B40B116942DCC5B7A9B110F8743ABE58654BCF0F086BE7865AE7BE5F27DD878A949732B43DDAC6A50EC9CE070C202E15A167DA8B417A069DD8A865848CDE67315883B92D20F67AC2B7ADE3580EA7E5091BE4314B72E6DDEECDD74D957BB7DACEBA3C1A97C6D2E55ADC78CA0D9492B157CB794B1A1F8933DA14C7F480"));
            Console.ReadKey();
        }

        public static string Descrypt(string valor)
        {
            return FormsAuthentication.Decrypt(valor).UserData;
            //return Encoding.UTF8.GetString(MachineKey.Decode(valor, MachineKeyProtection.Encryption));
            //return Encoding.UTF8.GetString(MachineKey.Unprotect(Encoding.UTF8.GetBytes(valor), ));
            //var bytes = Convert.FromBase64String(valor);
            //bytes = System.Web.Security.MachineKey.Unprotect(bytes,
            //    "Microsoft.Owin.Security.Cookies.CookieAuthenticationMiddleware",
            //    "ApplicationCookie", "v1");

            //return System.Text.Encoding.UTF8.GetString(bytes);

        }
    }
}
