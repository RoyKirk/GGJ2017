using UnityEngine;
using System.Collections;
[RequireComponent(typeof(NavMeshAgent))]

public class Drone : MonoBehaviour
{
    public enum DroneState {Idle, Gather, Dig, Build}
    public DroneState myState;
    NavMeshAgent myAgent;
    GroundBlocks myDestination;
    public Vector3 myBaseLocation;

    public GameObject footStepPrefab;

    public bool isCarryingResource;

    public float buildTime;
    public float digTime;
    public float footStepDelay;

    float myDigTime;
    float myBuildTime;
    float footStepTimer;

	// Use this for initialization
	void Start ()
    {
        myState = DroneState.Idle;
        myAgent = GetComponent<NavMeshAgent>();
        myAgent.avoidancePriority = Random.Range(50, 100);
        AgentHandler.myDrones.Add(this);
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (myState)
        {
            case DroneState.Idle:
                if (myAgent.destination != myBaseLocation)
                {
                    myAgent.SetDestination(myBaseLocation);
                }
                break;
            case DroneState.Gather:
                if (Vector3.Distance(transform.position, myBaseLocation) > 1.0f)
                {
                    if (myAgent.destination != myBaseLocation)
                    {
                        myAgent.SetDestination(myBaseLocation);
                    }
                }
                else
                {
                    isCarryingResource = false;
                    AgentHandler.resourcesInBase++;
                    myState = DroneState.Idle;
                }
                break;
            case DroneState.Dig:
                if (Vector3.Distance(transform.position, myDestination.transform.position) > 1.0f)
                {
                    if (myAgent.destination != myDestination.transform.position)
                    {
                        myAgent.SetDestination(myDestination.transform.position);
                    }
                }
                else
                {
                    if (myDigTime < digTime)
                    {
                        myDigTime += Time.deltaTime;
                    }
                    else
                    {
                        myDigTime = 0;
                        isCarryingResource = true;
                        myState = DroneState.Gather;
                        myDestination.harvested = true;
                        myDestination.assignedTask = false;
                    }
                }
                break;
            case DroneState.Build:
                if (isCarryingResource == true)
                {
                    if (Vector3.Distance(transform.position, myDestination.transform.position) > 1.0f)
                    {
                        if (myAgent.destination != myDestination.transform.position)
                        {
                            myAgent.SetDestination(myDestination.transform.position);
                        }
                    }

                    else
                    {
                        if (myBuildTime < buildTime)
                        {
                            myBuildTime += Time.deltaTime;
                        }
                        else
                        {
                            myBuildTime = 0;
                            isCarryingResource = false;
                            myState = DroneState.Idle;
                            myDestination.assignedTask = false;
                            myDestination.CreateBuilding();
                        }
                    }
                }

                else
                {
                    if (Vector3.Distance(transform.position, myBaseLocation) > 1.0f)
                    {
                        if (myAgent.destination != myBaseLocation)
                        {
                            myAgent.SetDestination(myBaseLocation);
                        }
                    }

                    else if (AgentHandler.resourcesInBase > 0)
                    {
                        isCarryingResource = true;
                        AgentHandler.resourcesInBase--;
                    }
                }
                break;

            default:
                break;
        }

        SpawnFootstep();
	}

    public void SetDestination(GroundBlocks destination)
    {
        myDestination = destination;
    }

    public void SpawnFootstep()
    {
        if (footStepTimer < footStepDelay)
        {
            footStepTimer += Time.deltaTime;
        }
        else
        {
            footStepTimer = 0;
            Instantiate(footStepPrefab, transform.position, transform.rotation);
        }
    }

    public void KillDrone()
    {
        AgentHandler.myDrones.Remove(this);
        Destroy(this.gameObject);
    }

    public void CancelOrder()
    {
        if (isCarryingResource)
        {
            myState = DroneState.Gather;
        }
        else
        {
            myState = DroneState.Idle;
        }
    }
}
