using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Combat_Program;

namespace RPG
{
    interface ICanAttack
    {
        void Attack(Actor other);
        void Fire(Actor other);
        void Heal();
        void Freeze(Actor other);
        void Poison(Actor other);
    }
}
