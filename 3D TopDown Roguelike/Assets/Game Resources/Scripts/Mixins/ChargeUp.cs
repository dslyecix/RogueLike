using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mixins/ChargeUp")]

public class ChargeUp : MixinBase {

    [SerializeField] float chargeTime;
    private bool isCharged = false;
    private float chargeTimer;



    public override bool GlobalCheck()
    {
        if (isCharged == false)
        {
            chargeTimer += Time.deltaTime;
        }

        if (chargeTimer >= chargeTime)
        {
            isCharged = true;
        }

        return isCharged;
    }


    public override void Action()
    {
        isCharged = false;
        chargeTimer = 0;
    }

}
