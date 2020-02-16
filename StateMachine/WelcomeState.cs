using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;



namespace LifeStateMachine
{
    public class WelcomeState : State<Game>
    {
        public Game game;
        public Player player;


        private static WelcomeState _instance;

        private WelcomeState()
        {
            if (_instance != null)
            {
                return;
            }
            _instance = this;
        }

        public static WelcomeState Instance
        {

            get
            {
                if (_instance == null)
                {
                    new WelcomeState();
                }

                return _instance;
            }
        }

        public override void enterState(Game _owner)
        {
            Debug.Log("We are in the Welcome STATE!!");



        }

        public override void exitState(Game _owner)
        {

        }

        public override void updateState(Game _owner)
        {
           

        }


    }

}

