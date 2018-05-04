using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    [SerializeField] MixinCollection fireWeaponMixins;
    //[SerializeField] MixinCollection reloadMixins;

	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            fireWeaponMixins.CheckAndAction();
        }

    }
}
