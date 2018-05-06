using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRaycast : MixinBase {

    [SerializeField] List<Transform> muzzlePoints;
    [SerializeField] float range;

	public override void Action()
    {
        for (int i = 0; i < muzzlePoints.Count; i++)
        {
            RaycastHit hit;
            if (Physics.Raycast(muzzlePoints[i].position, muzzlePoints[i].forward, out hit, range))
            {
                Debug.DrawLine(muzzlePoints[i].position, hit.point, Color.red, 0.2f);
            } else {
                Debug.DrawRay(muzzlePoints[i].position, muzzlePoints[i].forward * range, Color.red, 0.2f);
            }
        }

    }
}
