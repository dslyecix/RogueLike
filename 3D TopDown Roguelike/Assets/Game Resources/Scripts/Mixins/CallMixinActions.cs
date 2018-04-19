using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMixinActions : MixinBase {

    public List<MixinBase> checkMixins;
	public List<MixinBase> actionMixins;

    public void CallActions()
    {
        for (int i = 0; i < checkMixins.Count; i++)
        {
            if (!checkMixins[i].Check())
            {
                Debug.Log("oops! " + checkMixins[i].name + " fucked up");
                return;
            }
        }
        
        for (int i = 0; i < actionMixins.Count; i++)
        {
            actionMixins[i].Action();
        }
    }
    
    

}
