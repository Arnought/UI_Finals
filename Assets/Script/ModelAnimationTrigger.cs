using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ModelAnimationTrigger : MonoBehaviour
{
    public Animator firstModelAnimator, secondModelAnimator;
    private string originalAnimationTrigger = "Idle";
    public float shuffleDelayBeforeAnimation = 0.5f;
    public float deadDelayBeforeAnimation = 2.0f;

    public void Shuffle(string animationTrigger)
    {
        firstModelAnimator.SetTrigger(animationTrigger);
        secondModelAnimator.SetTrigger(animationTrigger);
        Invoke("TriggerOriginalAnimation", shuffleDelayBeforeAnimation);
    }

    public void Dead(string animationTrigger)
    {
        firstModelAnimator.SetTrigger(animationTrigger);
        secondModelAnimator.SetTrigger(animationTrigger);
        Invoke("TriggerOriginalAnimation", deadDelayBeforeAnimation);
    }

    private void TriggerOriginalAnimation()
    {
        firstModelAnimator.SetTrigger(originalAnimationTrigger);
        secondModelAnimator.SetTrigger(originalAnimationTrigger);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }
}
