using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorTrigger : MixinBase {

    [SerializeField] Animator animator;
    [SerializeField] string trigger;

    public override void Action()
    {
        animator.SetTrigger(trigger);
    }

}
