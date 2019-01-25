using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// log entity is configurable. can be changed.

namespace pGina.Plugin.MFLoginPlugin.Entities
{
    class LogEntity
    {
        public LogEntity() { }
        User U = null;
        AuthMethod AM = null;
        bool Success = false;
        DateTime DT = DateTime.Now;
    }
}
