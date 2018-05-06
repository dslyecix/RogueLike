using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireProjectile : MixinBase {

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float fireForce;

    [SerializeField] List<Transform> muzzlePoints;

    public override void Action()
    {   
        for (int i = 0; i < muzzlePoints.Count; i++)
        {
            GameObject bulletGO = Instantiate(bulletPrefab, muzzlePoints[i].position, muzzlePoints[i].rotation);
            bulletGO.GetComponent<Rigidbody>().AddForce(fireForce * bulletGO.transform.forward, ForceMode.VelocityChange);
            
        }
    }

}
