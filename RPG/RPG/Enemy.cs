using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combat_Program
{
    // Object can harm the user. //
    class Enemy : Actor
    {
        public Enemy(float a, float b, float c, string d)
        {
            m_HP = a;
            m_Attack = b;
            m_Defence = c;
            m_Status = d;
        }
    }
}