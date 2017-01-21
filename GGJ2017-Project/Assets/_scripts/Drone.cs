using UnityEngine;
using System.Collections;
[RequireComponent(typeof(NavMeshAgent))]

public class Drone : MonoBehaviour
{
    public enum DroneState {Idle, Gather, Dig, Build}
    public DroneState myState;
    NavMeshAgent myAgent;
    Vector3 myDestination;

    public bool isCarryingResource;

    public float buildTime;
    public float digTime;

    float myDigTime;
    float myBuildTime;

	// Use this for initialization
	void Start ()
    {
        myState = DroneState.Idle;
        myAgent = GetComponent<NavMeshAgent>();
        AgentHandler.myDrones.Add(this);
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (myState)
        {
            case DroneState.Idle:
                break;
            case DroneState.Gather:
                myAgent.SetDestination(Vector3.one); //destination should be base
                Debug.Log(myAgent.destination);
                break;
            case DroneState.Dig:
                if (Vector3.Distance(transform.position, myDestination) > 1.0f)
                {
                    if (myAgent.destination != myDestination)
                    {
                        myAgent.SetDestination(myDestination);
                    }
                }
                else
                {
                    myAgent.Stop();
                    if (myDigTime < digTime)
                    {
                        myDigTime += Time.deltaTime;
                    }
                    else
                    {
                        myDigTime = 0;
                        myState = DroneState.Gather;
                    }
                }
                break;
            case DroneState.Build:
                break;

            default:
                break;
        } 
	}

    public void SetDestination(Vector3 destination)
    {
        myDestination = destination;
    }
}
