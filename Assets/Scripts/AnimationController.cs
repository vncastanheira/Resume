using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SeekAndDestroyBehaviour))]
public class AnimationController : MonoBehaviour
{
    SeekAndDestroyBehaviour behaviour;
    public Animator animator;

	void Start ()
    {
        behaviour = GetComponent<SeekAndDestroyBehaviour>();
    }
	
	void Update ()
    {
        animator.SetFloat("Direction", behaviour.Direction);
    }
}
