﻿using UnityEngine;
using System.Collections;

public class PlayerPulseScript : MonoBehaviour
{
    /// <summary>
    /// current bug is that the pulse force seems to be way to big even at a small number, maybe it is triggering multiple times?
    /// collider needs to be reset, so that it turns off.
    /// </summary>


    PlayerControllerNew playerController;
    int player = 0;

    public SphereCollider collider;

    public float pulseDelay = 1;
    float currentPulseDelay = 0;

	// Use this for initialization
	void Start ()
    {
        playerController = GetComponentInParent<PlayerControllerNew>();
        player = playerController.player;
        collider = GetComponent<SphereCollider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentPulseDelay += Time.deltaTime;
        if(currentPulseDelay >= pulseDelay)
        {
            if (Controller.state[player].Buttons.A == XInputDotNetPure.ButtonState.Pressed)
            {
                collider.enabled = true;
                //still need to reset this so it turns off, maybe use a bool to control duration, eg. see thrust
            }
        }
	}

    public float PulseForce = 300;
    public float PulseRadius = 5;

    void OnCollisionEnter(Collision c)
    {
        if(c.transform.tag == "Player")
        {
            c.rigidbody.AddExplosionForce(PulseForce, transform.position, PulseRadius);
        }
    }
}