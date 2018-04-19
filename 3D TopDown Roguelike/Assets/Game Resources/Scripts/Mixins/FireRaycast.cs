using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRaycast : MixinBase {

    [SerializeField] private Transform firePosition;
    [SerializeField] private float range;

	public override void Action()
    {
        RaycastHit hit;
        Physics.Raycast(firePosition.position, firePosition.forward, out hit, range);
    }

}
