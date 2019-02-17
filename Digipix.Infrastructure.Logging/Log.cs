using log4net;
using System;
using System.Reflection;

namespace Digipix.Infrastructure.Logging
{
    public static class Log
    {
        private static  readonly ILog logar = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void Error(Exception ex, string metodo)
        {
            logar.Error(metodo, ex);
        }


    }
}
