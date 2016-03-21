using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG;

namespace Combat_Program
{
    // Object's abilites and attacks in battle. //
    public class Actor : ICanTakeActions, ICanAttack
    {
        protected string m_Name;
        protected float m_maxHP;
        protected float m_HP;
        protected float m_Attack;
        protected float m_Defence;
        protected string m_Status;

        public float AttackP
        {
            get
            {
                return m_Attack;
            }

            set
            {
                m_Attack = value;
            }
        }

        public float HP
        {
            get
            {
                return m_HP;
            }

            set
            {
                m_HP = value;
            }
        }

        public float Defence
        {
            get
            {
                return m_Defence;
            }

            set
            {
                m_Defence = value;
            }
        }

        public string Status
        {
            get
            {
                return m_Status;
            }

            set
            {
                m_Status = value;
            }
        }

        public float maxHP
        {
            get
            {
                return m_maxHP;
            }

            set
            {
                m_maxHP = value;
            }
        }

        public void Attack(Actor other)
        {
            Random rnd = new Random();
            int Roll = rnd.Next(-5, 11);
            float Damage = ((this.m_Attack - other.m_Defence) + Roll);
            if (Damage < 0)
            { Damage = 0; }
            other.m_HP -= Damage;
        }

        public void Fire(Actor other)
        {
            Simi_Random rnd = new Simi_Random();
            int Roll = rnd.rNum();
            float Damage = ((this.m_Attack - other.m_Defence) + Roll);
            if (Damage < 0)
            { Damage = 0; }
            other.m_HP -= Damage;

            Random Luck = new Random();
            int BurnChance = Luck.Next(1, 101);
            if (BurnChance < 10)
            {
                if (other.m_Status == "")
                { other.m_Status = "Burned"; }
            }
        }

        public void Heal()
        {
            m_HP += 20;
        }

        public void Freeze(Actor other)
        {
            Simi_Random rnd = new Simi_Random();
            int Roll = rnd.rNum();
            other.m_HP -= Roll;
            if (other.m_Status == "")
            { other.m_Status = "Frozen"; }
        }

        public void Poison(Actor other)
        {
            Simi_Random rnd = new Simi_Random();
            int Roll = rnd.rNum();
            other.m_HP -= Roll;
            if (other.m_Status == "")
            { other.m_Status = "Poisoned"; }
        }
    }
}