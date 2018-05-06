using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MixinBase {

    [SerializeField] Animator animator;
    [SerializeField] string trigger;
    private bool isReady = true;

    public override bool GlobalCheck()
    {
        return isReady;
    }

    public override void Action()
    {
        animator.SetTrigger(trigger);
    }

    public void AnimationComplete()
    {
        Debug.Log("Animation Event Triggered: " + trigger);
        isReady = true;
    }

}