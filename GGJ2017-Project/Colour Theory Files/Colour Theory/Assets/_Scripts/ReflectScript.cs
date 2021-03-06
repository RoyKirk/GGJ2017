﻿using UnityEngine;
using System.Collections;

public class ReflectScript : MonoBehaviour
{
    
    PlayerControllerNew playerController;
    int player = 0;

    public BoxCollider collider;

    public float ReflectDelay = 1;
    public float currentReflectDelay = 0;
    public float reflectDuration = 0.3f;

    public GameObject reflectAnim;
    public bool wall;

    // Use this for initialization
    void Start()
    {
        
        if(!wall)
        {
            playerController = GetComponentInParent<PlayerControllerNew>();
            player = playerController.player;
            collider = GetComponent<BoxCollider>();
            Physics.IgnoreCollision(GetComponentInParent<Collider>(), GetComponent<Collider>());
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(wall)
        {
            collider.enabled = true;
            reflectAnim.SetActive(true);
        }
        else
        {
            currentReflectDelay += Time.deltaTime;
            if (currentReflectDelay >= ReflectDelay)
            {
                //if (Controller.state[player].Buttons.X == XInputDotNetPure.ButtonState.Pressed)
                if(Controller.state[player].Triggers.Left >= 0.2)
                {
                    collider.enabled = true;
                    currentReflectDelay = 0;
                    reflectAnim.SetActive(true);
                    //still need to reset this so it turns off, maybe use a bool to control duration, eg. see thrust
                }
            }

            if (currentReflectDelay >= reflectDuration)
            {
                reflectAnim.SetActive(false);
                collider.enabled = false;
            }
        }
        
    }
}

