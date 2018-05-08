using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class MixinBase : ScriptableObject {
    
    public string Name;

    [HideInInspector]
    public bool showMixin = true;
    [HideInInspector]
    public bool showInfo;

    // Global checks are intended to halt the 'entire process' of a set of Mixins.  Eg if
    // an animation hasn't finished playing, we don't want allow ANY of the shoot logic
    // to begin to happen.
    public virtual bool GlobalCheck()
    {
        return true;
    }

    // Local checks are intended to halt ONLY the Action of the specific Mixin they belong to.
    // Eg if a particle effect hasn't finished playing, maybe we don't want to allow it to start
    // over again, however we still want to allow the rest of the logic to proceed.
    public virtual bool LocalCheck()
    {
        return true;
    }

	public virtual void Action()
    {

    }

    public virtual void CheckAndAction()
    {
        if (LocalCheck())
            Action();
    }
}
