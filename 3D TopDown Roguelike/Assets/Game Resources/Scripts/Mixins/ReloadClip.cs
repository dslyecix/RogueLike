using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadClip : MixinActionable {

    [SerializeField] FloatData clip;

    public override bool Check()
    {
        return actionMixin.Check();
    }

    public override void Action()
    {
        if (actionMixin.Check())
        {
            
            actionMixin.Action();
            clip.SetData(clip.maxValue);
        }

    }
}
