using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixinCollectionTrigger : MonoBehaviour {

	public MixinCollection collection;
    public KeyCode key;

        void Update ()
    {
        if (Input.GetKeyDown(key))
        {
            collection.CheckAndAction();
        }
    }

}
