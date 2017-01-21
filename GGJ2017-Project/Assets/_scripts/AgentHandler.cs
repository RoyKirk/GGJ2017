﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgentHandler : MonoBehaviour
{
    public static List<Drone> myDrones = new List<Drone>();
    public static List<Transform> digOrders = new List<Transform>();
    public static List<Transform> buildOrders = new List<Transform>();

    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                buildOrders.Add(hit.transform);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                digOrders.Add(hit.transform);
            }
        }

        foreach (Drone currentDrone in myDrones)
        {
            if (digOrders.Count > 0 && currentDrone.myState == Drone.DroneState.Idle)
            {
                currentDrone.myState = Drone.DroneState.Dig;
                currentDrone.SetDestination(digOrders[0].position);
                digOrders.RemoveAt(0);
                continue;
            }

            if (buildOrders.Count > 0 && currentDrone.myState == Drone.DroneState.Gather)
            {
                currentDrone.myState = Drone.DroneState.Build;
                currentDrone.SetDestination(buildOrders[0].position);
                buildOrders.RemoveAt(0);
                continue;
            }

            //bring resources to base

            //
        }
        //check that tile has resources
        //check that tile is reachable
        //agent does thing
    }
}
