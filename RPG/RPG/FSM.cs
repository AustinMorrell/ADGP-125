using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM_Program
{
    class FSM
    {
        public enum MyState
        {
            init,
            pause,
            running,
            battle,
        }

        Transition To_running = new Transition(MyState.init.ToString(), MyState.running.ToString());
        Transition To_running2 = new Transition(MyState.pause.ToString(), MyState.running.ToString());
        Transition To_running3 = new Transition(MyState.battle.ToString(), MyState.running.ToString());
        Transition To_pause = new Transition(MyState.running.ToString(), MyState.pause.ToString());
        Transition To_battle = new Transition(MyState.running.ToString(), MyState.battle.ToString());
        Transition To_battle2 = new Transition(MyState.pause.ToString(), MyState.battle.ToString());

        public static List<Transition> From_init;
        public static List<Transition> From_running;
        public static List<Transition> From_pause;
        public static List<Transition> From_battle;

        Dictionary<string, List<Transition>> TransitionTable = new Dictionary<string, List<Transition>>();
        private List<string> _states = new List<string>();

        public string _currentState;

        public FSM(string initial)
        {
            _currentState = initial;
            From_init = new List<Transition>(new Transition[] { To_running });
            From_running = new List<Transition>(new Transition[] { To_pause, To_battle });
            From_pause = new List<Transition>(new Transition[] { To_running, To_battle });
            From_battle = new List<Transition>(new Transition[] { To_running, To_pause });
        }

        public bool AddState(string state, List<Transition> a)
        {
            if (_states.Contains(state))
            {
                Console.WriteLine("Nope");
                return false;
            }
            else
            {
                _states.Add(state);
                TransitionTable.Add(state, a);
                return true;
            }
        }

        public void info()
        {
            Console.WriteLine("FSM is comprised of...");
            int count = 0;
            foreach (string a in _states)
            {
                Console.WriteLine("State " + count.ToString() + ": " + a.ToString());
                count++;
            }
            Console.WriteLine("State: " + _currentState);
        }

        public void ChangeState(string delta)
        {
            switch (delta)
            {
                case "Running":
                    if (TransitionTable[_currentState].Contains(To_running) || TransitionTable[_currentState].Contains(To_running2) || TransitionTable[_currentState].Contains(To_running3))
                    {
                        _currentState = "running";
                    }
                    break;

                case "Pause":
                    if (TransitionTable[_currentState].Contains(To_pause) || TransitionTable[_currentState].Contains(To_pause))
                    {
                        _currentState = "pause";
                    }
                    break;

                case "Battle":
                    if (TransitionTable[_currentState].Contains(To_battle) || TransitionTable[_currentState].Contains(To_battle2))
                    {
                        _currentState = "battle";
                    }
                    break;
            }
        }
    }
}