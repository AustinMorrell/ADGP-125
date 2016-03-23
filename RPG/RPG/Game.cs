using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FSM_Program;
using Combat_Program;

namespace RPG
{
    [Serializable]
    class Game
    {
        public FSM fsm = new FSM(FSM.MyState.init.ToString());
        public List<Player> Party = new List<Player>();
        private Player M1 = new Player("Cloud", 100, 20, 5, "", @"C:\Users\Austin.Morrell\Desktop\ADGP 125\RPG\RPG\bin\Images\Cloud.gif", 1, 2, 3);
        private Player M2 = new Player("Shadow", 100, 20, 5, "", @"C:\Users\Austin.Morrell\Desktop\ADGP 125\RPG\RPG\bin\Images\Shadow.gif", 1, 4, 3);
        private Player M3 = new Player("Ben Odom", 100, 20, 5, "", @"C:\Users\Austin.Morrell\Desktop\ADGP 125\RPG\RPG\bin\Images\BenOdom.jpeg", 1, 3, 5);

        public Game()
        {
            fsm.AddState(FSM.MyState.init.ToString(), FSM.From_init);
            fsm.AddState(FSM.MyState.running.ToString(), FSM.From_running);
            fsm.AddState(FSM.MyState.pause.ToString(), FSM.From_pause);
            fsm.AddState(FSM.MyState.battle.ToString(), FSM.From_battle);
            Party.Add(M1);
            Party.Add(M2);
            Party.Add(M3);
            fsm._currentState = "running";
        }
    }
}
