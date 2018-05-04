using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MixinBase {

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePoint;

    public override void Action()
    {   
        Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
    }

}
