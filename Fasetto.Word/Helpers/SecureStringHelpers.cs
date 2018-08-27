using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    public static class SecureStringHelpers
    {
        public static string Unsecure(this SecureString secureString)
        {
            if (secureString == null)
                return string.Empty;

            var unmangedString = IntPtr.Zero;

            try
            {
                unmangedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);

                return Marshal.PtrToStringUni(unmangedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmangedString);
            }
        }
    }
}
