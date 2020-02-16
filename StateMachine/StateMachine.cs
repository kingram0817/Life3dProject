using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


namespace LifeStateMachine
{
    public class StateMachine<T>
    {
        public State<T> currentState { get; set; }
        public T Owner;


        public StateMachine(T _owner)
        {
            Owner = _owner;
            currentState = null;

        }

        public void changeState(State<T> newState)
        {
            if (currentState != null)
            {
                currentState.exitState(Owner);
            }


            currentState = newState;
            currentState.enterState(Owner);
        }

        public void update()
        {
            if (currentState != null)
            {
                currentState.updateState(Owner);
            }

        }
    }
}

