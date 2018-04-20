using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MixinBase {

    [SerializeField] private float cooldownTimer;
    private float cooldownTime = 0f;
    private bool isReady;
	
    public override bool Check()
    {
        return isReady;
    }

    public override void Action()
    {
        isReady = false;
        cooldownTime = 0f;
    }

    void Update()
    {
        if (!isReady)
        {
            cooldownTime += Time.deltaTime;
            if (cooldownTime > cooldownTimer)
            {
                isReady = true;
            }
        }
    }
}
