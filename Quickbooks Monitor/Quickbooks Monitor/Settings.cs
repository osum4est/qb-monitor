using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quickbooks_Monitor
{
    public class Settings
    {
        public static Settings Current;

        public bool minimizeWarning;

        public string directory;

        public bool autoSearch;
        public bool startMinimized;
        public bool openAll;

        public Settings()
        {
            Current = this;
        }
    }
}
