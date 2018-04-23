using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] CallMixinActions fireWeaponMixins;
    [SerializeField] MixinBase reloadMixin;

    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Space bar detected");
            fireWeaponMixins.CallActions();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            reloadMixin.CheckAndAction();
        }
	
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        float mouseHorizontal = Input.GetAxis("Mouse X");


        this.transform.position += this.transform.forward * vertical * moveSpeed * Time.deltaTime;
        this.transform.position += this.transform.right * horizontal * moveSpeed * Time.deltaTime;
        

        Quaternion newDir = Quaternion.RotateTowards(transform.rotation, )
         this.transform.rotation = Quaternion.FromToRotation(this.transform.rotation, )
    }


}
