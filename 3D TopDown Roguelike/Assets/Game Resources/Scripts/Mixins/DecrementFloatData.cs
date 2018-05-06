using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementFloatData : MixinBase {

    [SerializeField] FloatData data;
    [SerializeField] float decrementAmount;
    float currentValue;

    public override bool GlobalCheck()
    {
        currentValue = data.GetData();
        if (currentValue - decrementAmount >= 0)
        {
            return true;
        }
        return false;
    }

    public override void Action()
    {
        data.SetData(currentValue - decrementAmount);
    }

}
