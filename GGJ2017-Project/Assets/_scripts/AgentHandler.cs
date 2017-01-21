using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AgentHandler : MonoBehaviour
{
    public static List<Drone> myDrones = new List<Drone>();
    public static List<Transform> digOrders = new List<Transform>();
    public static List<Transform> buildOrders = new List<Transform>();

    public GameObject dronePrefab;

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

        SpawnDrones();

        foreach (Drone currentDrone in myDrones)
        {
            currentDrone.myBaseLocation = transform.position;
            if (digOrders.Count > 0 && currentDrone.myState == Drone.DroneState.Idle)
            {
                currentDrone.myState = Drone.DroneState.Dig;
                currentDrone.SetDestination(digOrders[0].position);
                digOrders.RemoveAt(0);
                continue;
            }

            if (buildOrders.Count > 0)
            {
                if (currentDrone.myState == Drone.DroneState.Gather)
                {
                    currentDrone.myState = Drone.DroneState.Build;
                    currentDrone.SetDestination(buildOrders[0].position);
                    buildOrders.RemoveAt(0);
                    continue;
                }

                else if (currentDrone.myState == Drone.DroneState.Idle && resourcesInBase > 0)
                {
                    currentDrone.myState = Drone.DroneState.Build;
                    currentDrone.SetDestination(buildOrders[0].position);
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
