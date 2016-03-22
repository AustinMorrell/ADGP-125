using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leveling_System;

namespace Combat_Program
{
    // Object is the representation of the user. //
    [Serializable]
    public class Player : Actor, IControllable, ILevelable
    {
        private string m_Input;
        List<double> m_Curve = new List<double>();
        private int m_maxLevel = 100;
        private int m_maxEXP = 0;
        private double m_EXP = 0;

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

        public string Input
        {
            get
            {
                return m_Input;
            }

            set
            {
                m_Input = value;
            }
        }

        public double EXP
        {
            get
            {
                return m_EXP;
            }

            set
            {
                m_EXP = value;
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

        public List<double> Curve
        {
            get
            {
                return m_Curve;
            }

            set
            {
                m_Curve = value;
            }
        }

        public int maxLevel
        {
            get
            {
                return m_maxLevel;
            }

            set
            {
                m_maxLevel = value;
            }
        }

        public int maxEXP
        {
            get
            {
                return m_maxEXP;
            }

            set
            {
                m_maxEXP = value;
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

        public void LevelCurve()
        {
            double TempEXPNumber = 0;
            for (int i = 1; i < maxLevel; i++)
            {
                TempEXPNumber = Math.Pow(i, 2);
                Curve.Add(TempEXPNumber);
            }
            maxEXP = (int)Curve[98];
        }

        public void LevelUp()
        {
            if (EXP > Curve[Level])
            {
                for (; EXP > Curve[Level];)
                {
                    Level++;
                }
            }
        }

        public Player(string e, float a, float b, float c, string d, string f)
        {
            m_Name = e;
            m_maxHP = a;
            m_Attack = b;
            m_Defence = c;
            m_Status = d;
            m_Level = 1;
            m_Image = f;
        }

        public Player()
        {}
    }
}
