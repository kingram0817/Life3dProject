using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State<T>
{

    public abstract void enterState(T _owner);
    public abstract void exitState(T _owner);
    public abstract void updateState(T _owner);

}