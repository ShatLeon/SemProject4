using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideOnEnter : MonoBehaviour
{

    public GameObject[] Target ;
    public bool Hide ;


    
    void OnTriggerEnter(Collider other)
    {

        //Debug.Log("Test") ;


        if (other.CompareTag("Player"))
        {
            Debug.Log("Funktioniert Blyat") ;


            for (int i = 0; i < Target.Length; i++)
            {
                Target[i].SetActive(false) ;
                
                //Target[i].SetActive(true) ;
            }



        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collider Exit");
            for (int i = 0; i < Target.Length; i++)
            {
                Target[i].SetActive(true);
            }
        }

        
    }


}
