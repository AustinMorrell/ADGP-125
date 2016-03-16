using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Program
{
    // Object can be controlled by the user. //
    interface IControllable
    {
        string Input
        {
            get; set;
        }
    }
}
