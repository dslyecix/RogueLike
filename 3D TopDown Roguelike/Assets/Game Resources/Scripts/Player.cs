using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] CallMixinActions fireWeaponMixins;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space bar detected");
            fireWeaponMixins.CallActions();
        }
	
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        this.transform.position += this.transform.forward * vertical * moveSpeed * Time.deltaTime;
        this.transform.position += this.transform.right * horizontal * moveSpeed * Time.deltaTime;
        
    }


}
