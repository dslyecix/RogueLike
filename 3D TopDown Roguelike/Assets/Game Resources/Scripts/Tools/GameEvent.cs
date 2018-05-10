using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject {

	private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener (GameEventListener listener)
    {
        if (listener != null)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
            } else {
                Debug.Log("Listener " + listener.name + " registration failed on " + this.name);
            }
        }
    }

    public void UnregisterListener (GameEventListener listener)
    {
        if (listener != null)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            } else {
                Debug.Log("Listener " + listener.name + " registration failed on " + this.name);
            }
        }
    }
}
