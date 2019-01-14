using System;
using System.Collections.Generic;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> changedItems)
        {
            foreach (var item in changedItems)
            {
                Console.WriteLine(item.Log());
            }
        }
    }
}
