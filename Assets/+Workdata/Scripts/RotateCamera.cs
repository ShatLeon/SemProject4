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
                ChangeDirection(true, false, false, false, true, false, false, false);          
            }
            else if (Input.GetKeyDown(KeyCode.E) && eastDirection == true)
            {

                //ChangeDirection(true, false, false, false, false, true, false, false);

                StateManager.SetState(gameObject, "East", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", true);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", false);//The State will swtich to face East
                eastDirection = false;
                northDirection = false;
                southDirection = true;
                westDirection = false;
                SetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.E) && southDirection == true)
            {
                StateManager.SetState(gameObject, "East", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", true);//The State will swtich to face East
                eastDirection = false;
                northDirection = false;
                southDirection = false;
                westDirection = true;
                SetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.E) && westDirection == true)
            {
                StateManager.SetState(gameObject, "East", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", true);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", false);//The State will swtich to face East
                eastDirection = false;
                northDirection = true;
                southDirection = false;
                westDirection = false;
                SetTimer();
            }

            else if (Input.GetKeyDown(KeyCode.Q) && northDirection == true)
            {
                StateManager.SetState(gameObject, "East", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", true);//The State will swtich to face East
                eastDirection = false;
                northDirection = false;
                southDirection = false;
                westDirection = true;
                SetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && eastDirection == true)
            {
                StateManager.SetState(gameObject, "East", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", true);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", false);//The State will swtich to face East
                eastDirection = false;
                northDirection = true;
                southDirection = false;
                westDirection = false;
                SetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && southDirection == true)
            {
                StateManager.SetState(gameObject, "East", true);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", false);//The State will swtich to face East
                eastDirection = true;
                northDirection = false;
                southDirection = false;
                westDirection = false;
                SetTimer();
            }
            else if (Input.GetKeyDown(KeyCode.Q) && westDirection == true)
            {
                StateManager.SetState(gameObject, "East", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "North", false);//The State will swtich to face East
                StateManager.SetState(gameObject, "South", true);//The State will swtich to face East
                StateManager.SetState(gameObject, "West", false);//The State will swtich to face East
                eastDirection = false;
                northDirection = false;
                southDirection = true;
                westDirection = false;
                SetTimer();
            }
        }
    }

    void ChangeDirection(bool east, bool north, bool south, bool west, bool eastDir, bool northDir, bool southDir, bool westDir)
    {
        StateManager.SetState(gameObject, "East", east);//The State will swtich to face East
        StateManager.SetState(gameObject, "North", north);//The State will swtich to face East
        StateManager.SetState(gameObject, "South", south);//The State will swtich to face East
        StateManager.SetState(gameObject, "West", west);//The State will swtich to face East
        eastDirection = eastDir;
        northDirection = northDir;
        southDirection = southDir;
        westDirection = westDir;
        SetTimer();
    }
}

