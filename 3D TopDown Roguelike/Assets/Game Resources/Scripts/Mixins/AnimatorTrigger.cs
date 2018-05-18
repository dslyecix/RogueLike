using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mixins/AnimatorTrigger")]
public class AnimatorTrigger : MixinBase {

<<<<<<< HEAD
    [SerializeField] List<Animator> animators = new List<Animator>();
=======
    [SerializeField] Animator animator;
>>>>>>> parent of 58e9d58... Work 2
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