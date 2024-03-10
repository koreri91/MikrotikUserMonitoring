using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikrotikUserMonitoring.controller
{
    public interface ImplEventChangeListener
    {
        void onPushToUpdateData();
    }
}
