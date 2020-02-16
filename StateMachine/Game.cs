using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



namespace LifeStateMachine
{
    public class Game : MonoBehaviour
    {

        public StateMachine<Game> StateMachine { get; set; }
        public State<Game> State;
        public bool switchState = false;

        public void start()
        {
           
            StateMachine = new StateMachine<Game>(this);
            StateMachine.changeState(WelcomeState.Instance);
            WelcomeState.Instance.enterState(this);



        }
       


        public void Update()
        {
           // StateMachine.update();
        }


    }
    
}

