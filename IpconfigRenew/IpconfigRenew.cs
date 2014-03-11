using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IpconfigRenew
{
    class IpconfigRenew
    {
        static void Main()
        {
            Process.Start("ipconfig", "/renew");
            Environment.Exit(1);
        }
    }
}
