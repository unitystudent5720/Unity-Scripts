using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator;
    public string trigger;
    public bool onEnter = true;
    public bool onExit;
    private void OnTriggerEnter(Collider other)
    {
        if (onEnter)
        {
            animator.SetTrigger(trigger);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (onExit)
        {
            animator.SetTrigger(trigger);
        }
    }
}
