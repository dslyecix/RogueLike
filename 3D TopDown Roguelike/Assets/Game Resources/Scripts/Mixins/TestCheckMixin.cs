using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCheckMixin : MonoBehaviour {

    [SerializeField] MixinBase mixin;
    public bool Test;

    void Update()
    {
        Test = mixin.Check();
    }

    public MixinBase ReturnMixin()
    {
        return mixin;
    }
}
