using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("end");
    }
}
