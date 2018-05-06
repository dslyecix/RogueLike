using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldWeapon : MonoBehaviour {

    [SerializeField] MixinCollection fireWeaponMixins;
    //[SerializeField] MixinCollection reloadMixins;

	void Update () {
		if (Input.GetButton("Fire1"))
        {
            fireWeaponMixins.CheckAndAction();
        }
    }
}
