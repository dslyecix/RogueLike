﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour {

	public GameEvent Event;
    public UnityEvent Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDistable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised ()
    {
        Response.Invoke();
    }

}
