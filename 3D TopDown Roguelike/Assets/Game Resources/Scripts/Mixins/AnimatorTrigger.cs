using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Mixins/AnimatorTrigger")]
public class AnimatorTrigger : MixinBase {

    [SerializeField] List<Animator> animators;
    [SerializeField] string trigger;
    private bool isReady = true;

    public override bool GlobalCheck()
    {
        return isReady;
    }

    public override void Action()
    {
        for (int i = 0; i < animators.Count; i++)
        {
            animators[i].SetTrigger(trigger);
        }
    }

    public void AnimationComplete()
    {
        Debug.Log("Animation Event Triggered: " + trigger);
        isReady = true;
    }

}