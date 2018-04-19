using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clip : MixinBase {

    [SerializeField] private float maxClipSize;
    [SerializeField] private float ammoPerShot;
	private float currentClipSize;

    void Start()
    {
        currentClipSize = maxClipSize;
    }

    public override bool Check()
    {
        if (currentClipSize >= ammoPerShot)
        {
            return true;
        }
        return false;
    }
    public override void Action()
    {
        currentClipSize -= ammoPerShot;
    }

}
