using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Selen
{
    public class RunningSettings
    {
        private static int waitTime = DefaultTimeOut;
        public static int DefaultTimeOut
        {
            get { return 10; }
        }

        public static int WaitTime
        {
            get
            {
                return waitTime;
            }

            set
            {
                waitTime = value;
            }
        }
    }
}
