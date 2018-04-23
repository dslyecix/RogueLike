using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatData : MonoBehaviour {

	[SerializeField] float data;
    public float maxValue;

    public float GetData() { return data; }
    public void SetData(float newData) { data = newData; }

    public void incrementData(float num) { data += num; }

    void Update()
    {
        if(data > maxValue)
            data = maxValue;
    }
}
