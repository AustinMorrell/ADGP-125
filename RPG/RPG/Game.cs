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
    class Game
    {
        public FSM fsm = new FSM(FSM.MyState.init.ToString());
        
        public Game()
        {
            fsm.AddState(FSM.MyState.init.ToString(), FSM.From_init);
            fsm.AddState(FSM.MyState.running.ToString(), FSM.From_running);
            fsm.AddState(FSM.MyState.pause.ToString(), FSM.From_pause);
            fsm.AddState(FSM.MyState.battle.ToString(), FSM.From_battle);
        }

        public void GameLoop()
        {
            while(true)
            {
                Application.Run(new ADGP125());
                switch (fsm._currentState)
                {
                    case "init":
                        fsm._currentState = "running";
                        break;

                    case "running":

                        break;

                    case "pause":

                        break;

                    case "battle":
                        // Battle();
                        // Will be ^ when done but for now: //
                        Player You = new Player(100, 20, 5, "");
                        Enemy BadGuy = new Enemy(500, 10, 7, "");

                        Console.WriteLine("Your HP: " + You.HP + "                      Enemies HP: " + BadGuy.HP + "\n");
                        Console.WriteLine("Your Status: " + You.Status + "                      Enemies Status: " + BadGuy.Status + "\n");
                        Console.WriteLine("A really bad guy showed up in front of you!\n" + "Choose an attack to use!\n");
                        Console.WriteLine("1 - Attack" + "\n");
                        Console.WriteLine("2 - Fire" + "\n");
                        Console.WriteLine("3 - Heal" + "\n");
                        Console.WriteLine("4 - Freeze" + "\n");
                        Console.ReadLine();
                        break;
                }
            }
        }

        void Battle()
        {

        }
    }
}
