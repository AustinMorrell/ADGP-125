using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leveling_System
{
    interface ILevelable
    {
        int Level
        {
            get; set;
        }

        double EXP
        {
            get; set;
        }

        int maxLevel
        {
            get; set;
        }

        int maxEXP
        {
            get; set;
        }

        List<double> Curve
        {
            get; set;
        }

        void LevelCurve();

        void LevelUp();
    }
}
