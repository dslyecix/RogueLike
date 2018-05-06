using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MixinCollection : MixinBase {

    // This class will first check all of the GlobalChecks for a given set of Mixins,
    // then run through the individual mixins' LocalChecks -> Actions

    // Can execute all of this with MixinCollection.CheckAndAction(); (Globals are automatically checked)
    [HideInInspector]
	public List<MixinBase> actionMixins;

    public override void Action()
    {
        if (actionMixins != null)
        {
            for (int i = 0; i < actionMixins.Count; i++)
            {
                if (actionMixins[i] != null)    
                {
                    actionMixins[i].CheckAndAction();
                }
            }
       }
    }

    public override bool GlobalCheck()
    {
        if (actionMixins != null)
        {
            for (int i = 0; i < actionMixins.Count; i++)
            {
                if (actionMixins[i] != null)    
                {
                    if (!actionMixins[i].GlobalCheck())
                    {
                        return false;
                    }
                }
            }
       }
       return true;
    }

    public override bool LocalCheck()
    {
        return GlobalCheck();
    }


}   
