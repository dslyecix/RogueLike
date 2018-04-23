using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MixinBase {

    [SerializeField] Animator animator;
    [SerializeField] string trigger;
    private bool isReady = true;

    public void AnimComplete(){
        Debug.Log("Animation Event Triggered: " + trigger.ToString());
        isReady = true;
    }

    public override bool Check()
    {
        return isReady;
    }

    public override void Action()
    {
        animator.SetTrigger(trigger);
        isReady = false;
    }

}
