using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckFloatData : MixinBase {

    [SerializeField] FloatData data;

    public override bool GlobalCheck()
    {
        if (data.GetData() > data.maxValue)
        {
            return true;
        }
        return false;
    }

}
