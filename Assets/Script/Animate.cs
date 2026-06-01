using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    Animator animator;

    public float moveX;
    public float moveY;
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        animator.SetFloat("MoveX", moveX);
        animator.SetFloat("MoveY", moveY);
    }
}
