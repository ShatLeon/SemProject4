using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] Animator item;


    private void OnTriggerEnter(Collider col)
    {

        Debug.Log("working") ;

        if (col.gameObject.CompareTag("Player"))
        {
            item.SetBool("Trigger", true);
        }

    }
}
