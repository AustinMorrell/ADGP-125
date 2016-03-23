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
        public int EXPDrop = 0;

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public string Image
        {
            get
            {
                return m_Image;
            }

            set
            {
                m_Image = value;
            }
        }

        public int Level
        {
            get
            {
                return m_Level;
            }

            set
            {
                m_Level = value;
            }
        }

        public Enemy(string e, float a, float b, float c, string d, string f, int g, int h, int i)
        {
            RPG.Simi_Random rnd = new RPG.Simi_Random();
            int Roll = rnd.rNum() + 20;
            m_Name = e;
            m_maxHP = a;
            m_Attack = b;
            m_Defence = c;
            m_Status = d;
            m_Level = Roll;
            EXPDrop = m_Level * (int)Math.Pow((m_Level / 5), 2);
            m_Image = f;
            Moves.Add(g);
            Moves.Add(h);
            Moves.Add(i);
        }
    }
}