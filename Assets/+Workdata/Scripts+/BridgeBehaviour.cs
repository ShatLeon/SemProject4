using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider col)
    {

        Debug.Log("Collider Working");

        if (col.gameObject.CompareTag("Player"))
        {
            col.GetComponent<CharacterComponents>().rotateCamera.ChangeDirection(false, false, false, false, false, true);
        }

    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.GetComponent<CharacterComponents>().rotateCamera.GetLastState();
        }

    }
}
