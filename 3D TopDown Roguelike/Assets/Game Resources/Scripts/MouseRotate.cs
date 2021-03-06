﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour {

    public FloatReference reference;

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
//    private float pitch = 0.0f;

    void Update () {
        yaw = speedH * Input.GetAxis("Mouse X");
        //pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.rotation *= Quaternion.AngleAxis(yaw * Time.deltaTime, Vector3.up);
    }
}

