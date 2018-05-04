using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceParentForward : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        //transform.rotation = Quaternion.LookRotation(this.transform.forward, Vector3.up);
       // transform.Rotate(transform.right, -transform.rotation.eulerAngles.y, Space.World);
	}
}
