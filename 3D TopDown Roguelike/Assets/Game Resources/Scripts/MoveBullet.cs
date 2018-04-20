using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour {

    [SerializeField] float bulletSpeed;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(transform.forward * bulletSpeed * Time.deltaTime);
	}
}
