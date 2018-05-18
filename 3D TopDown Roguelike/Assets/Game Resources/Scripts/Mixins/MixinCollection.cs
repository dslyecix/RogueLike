using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
[CreateAssetMenu]
=======
>>>>>>> parent of 58e9d58... Work 2
public class MixinCollection : MixinBase {

    public string name;

    // This class will first check all of the GlobalChecks for a given set of Mixins,
    // then run through the individual mixins' LocalChecks -> Actions

    // Can execute all of this with MixinCollection.CheckAndAction(); (Globals are automatically checked)
<<<<<<< HEAD
    //[HideInInspector]
=======

>>>>>>> parent of 58e9d58... Work 2
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
