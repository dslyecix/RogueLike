using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallMixinActions : MixinBase {

    public List<MixinBase> checkMixins;
	public List<MixinBase> actionMixins;

    public void CallActions()
    {
        if (checkMixins != null)
        {
            for (int i = 0; i < checkMixins.Count; i++)
            {
                if(checkMixins[i] != null) 
                {    
                    if (!checkMixins[i].Check()) 
                    {
                        return;
                    }
                }
            }
        }   

        for (int i = 0; i < actionMixins.Count; i++)
        {
            if(actionMixins[i] != null)
            {  
                actionMixins[i].Action();
            }
        }
    }
}   
