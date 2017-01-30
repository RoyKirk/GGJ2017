﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgentHandler : MonoBehaviour
{
    public static List<Drone> myDrones = new List<Drone>();
    public static List<GroundBlocks> digOrders = new List<GroundBlocks>();
    public static List<GroundBlocks> buildOrders = new List<GroundBlocks>();

    public GameObject dronePrefab;
    public AudioSource myAudio;

    public static int resourcesInBase;

    public int maxDrones;
    public float droneSpawnDelay;
    float droneSpawnTimer;

    // Use this for initialization
    void Awake ()
    {
        myDrones.Clear();
        digOrders.Clear();
        buildOrders.Clear();
        resourcesInBase = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f) && hit.transform.gameObject.tag == "Ground")
            {
                GroundBlocks currentblock = hit.transform.gameObject.GetComponent<GroundBlocks>();
                if (currentblock.assignedTask == false && currentblock.canBuildOn == true)
                {
                    buildOrders.Add(currentblock);
                    currentblock.assignedTask = true;
                    currentblock.buildAnimator.SetActive(true);
                }
            }
            myAudio.Play();
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f) && hit.transform.gameObject.tag == "Ground")
            {
                GroundBlocks currentblock = hit.transform.gameObject.GetComponent<GroundBlocks>();
                if (currentblock.assignedTask == false && currentblock.Depleted == false)
                {
                    digOrders.Add(currentblock);
                    currentblock.assignedTask = true;
                    currentblock.gatherAnimator.SetActive(true);
                }
            }
            myAudio.Play();
        }

        if (Input.GetMouseButtonDown(2))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f) && hit.transform.gameObject.tag == "Ground")
            {
                GroundBlocks currentblock = hit.transform.gameObject.GetComponent<GroundBlocks>();
                if (currentblock.assignedTask == true)
                {
                    currentblock.CancelOrder();
                    currentblock.cancelAnimator.SetActive(true);
                }
            }
            myAudio.Play();
        }

        SpawnDrones();

        foreach (Drone currentDrone in myDrones)
        {
            currentDrone.myBaseLocation = transform.position;
            if (digOrders.Count > 0 && currentDrone.myState == Drone.DroneState.Idle)
            {
                currentDrone.myState = Drone.DroneState.Dig;
                currentDrone.SetDestination(digOrders[0]);
                digOrders[0].myAssignedDrone = currentDrone;
                digOrders.RemoveAt(0);
                continue;
            }

            if (buildOrders.Count > 0)
            {
                if (currentDrone.myState == Drone.DroneState.Gather)
                {
                    currentDrone.myState = Drone.DroneState.Build;
                    currentDrone.SetDestination(buildOrders[0]);
                    buildOrders[0].myAssignedDrone = currentDrone;
                    buildOrders.RemoveAt(0);
                    continue;
                }

                else if (currentDrone.myState == Drone.DroneState.Idle && resourcesInBase > 0)
                {
                    currentDrone.myState = Drone.DroneState.Build;
                    currentDrone.SetDestination(buildOrders[0]);
                    buildOrders[0].myAssignedDrone = currentDrone;
                    buildOrders.RemoveAt(0);
                    continue;
                }
            }
        }
    }

    void SpawnDrones()
    {  
        if (myDrones.Count < maxDrones)
        {
            droneSpawnTimer += Time.deltaTime;

            if (droneSpawnTimer >= droneSpawnDelay)
            {
                Instantiate(dronePrefab, transform.position, transform.rotation);
                droneSpawnTimer = 0;
            }
        }
    }
}