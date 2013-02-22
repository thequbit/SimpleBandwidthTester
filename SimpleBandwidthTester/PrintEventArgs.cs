using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleBandwidthTester
{
    class PrintEventArgs : EventArgs
    {
        private string responceString;
        public string ResponceString
        {
            get { return responceString; }
        }

        public PrintEventArgs(string responceString)
        {
            this.responceString = responceString;
        }
    }
}
