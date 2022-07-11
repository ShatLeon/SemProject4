using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Opsive.UltimateCharacterController.StateSystem;
using Opsive.Shared.StateSystem;

public class RotateCamera : MonoBehaviour
{
    public float rotateTime;
    float rotateTimer;
    public bool northDirection;
    public bool eastDirection;
    public bool southDirection;
    public bool westDirection;
    public bool zoomDirection;
    public bool zoomBDirection;

    public int lastState;

    // Start is called before the first frame update
    void Start()
    {
        rotateTimer = 0;
        northDirection = true;
        StateManager.SetState(gameObject, "North", true);
    }


    void SetTimer()
    {
        rotateTimer = rotateTime;
    }
    // Update is called once per frame
    void Update()
    {
        rotateTimer -= Time.deltaTime;
        if (rotateTimer < 0)
        {

            if (Input.GetKeyDown(KeyCode.E) && northDirection) //If camera is facing North and Rotate Right Button is pressed
            {
                ChangeDirection(true, false, false, false, false, false);
                lastState = 0;
            }
            else if (Input.GetKeyDown(KeyCode.E) && eastDirection == true)
            {

                ChangeDirection(false, false, true, false, false, false) ;
                lastState = 1;
            }
            else if (Input.GetKeyDown(KeyCode.E) && southDirection == true)
            {

                ChangeDirection(false, false, false, true, false, false) ;
                lastState = 2;
            }
            else if (Input.GetKeyDown(KeyCode.E) && westDirection == true)
            {
                ChangeDirection(false, true, false, false, false, false) ;
                lastState = 3;
            }

            else if (Input.GetKeyDown(KeyCode.Q) && northDirection == true)
            {
                ChangeDirection(false, false, false, true, false, false) ;
                lastState = 2;
            }
            else if (Input.GetKeyDown(KeyCode.Q) && eastDirection == true)
            {
                ChangeDirection(false, true, false, false, false, false) ;
                lastState = 3;
            }
            else if (Input.GetKeyDown(KeyCode.Q) && southDirection == true)
            {
                ChangeDirection(true, false, false, false, false, false) ;
                lastState = 0;
            }
            else if (Input.GetKeyDown(KeyCode.Q) && westDirection == true)
            {
                ChangeDirection(false, false, true, false, false, false) ;
                lastState = 1;
            }
        }
    }

    public void ChangeDirection(bool east, bool north, bool south, bool west, bool zoom, bool bridge)
    {
        StateManager.SetState(gameObject, "East", east);//The State will swtich to face East
        StateManager.SetState(gameObject, "North", north);//The State will swtich to face East
        StateManager.SetState(gameObject, "South", south);//The State will swtich to face East
        StateManager.SetState(gameObject, "West", west);//The State will swtich to face East
        StateManager.SetState(gameObject, "Zoom", zoom);//The State sill switch to face East
        StateManager.SetState(gameObject, "ZoomB", bridge);
        eastDirection = east;
        northDirection = north;
        southDirection = south;
        westDirection = west;
        zoomDirection = zoom;
        zoomBDirection = bridge;
        
    }

    public void GetLastState()
    {
        switch (lastState)
        {
            case 0:
                ChangeDirection(true, false, false, false, false, false) ;
                break;

            case 1:
                ChangeDirection(false, false, true, false, false, false) ;
                break;

            case 2:
                ChangeDirection(false, false, false, true, false, false) ;
                break;

            case 3:
                ChangeDirection(false, true, false, false, false, false) ;
                break;

            case 4:
                ChangeDirection(false, false, false, false, true, false) ;
                break;
        

            default:
                break;
        }
    }
}

