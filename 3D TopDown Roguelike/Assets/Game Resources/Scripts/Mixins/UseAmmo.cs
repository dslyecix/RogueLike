using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseAmmo : MixinActionable {

    [SerializeField] FloatData clip;
    [SerializeField] private float ammoPerShot;

    public override bool Check()
    {
        if (clip.GetData() - ammoPerShot < 0)
        {
            actionMixin.CheckAndAction();
            return false;
        }
        return true;
    }
        
    
    public override void Action()
    {
        clip.incrementData(-ammoPerShot);
    }

}
