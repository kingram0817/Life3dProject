using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface MessageSystem : IEventSystemHandler
{
    // Functions that can be called via the messaging system
    void Move(int diceValue);
}

