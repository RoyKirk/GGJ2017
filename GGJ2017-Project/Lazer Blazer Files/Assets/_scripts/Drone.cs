using UnityEngine;
using System.Collections;
[RequireComponent(typeof(NavMeshAgent))]

public class Drone : MonoBehaviour
{
    public enum DroneState {Idle, Gather, Dig, Build, Demolish}
    public DroneState myState;
	NavMeshAgent myAgent;
	GroundBlocks myDestination;
	BuildingBlock buildingToDemolish;
    public Vector3 myBaseLocation;

    public GameObject footStepPrefab;
    public ParticleSystem deathParticle;
    
    public GameObject walkAnimation;
    public GameObject resourceAnimation;

    public AudioSource myAudio;
    public AudioSource deathSound;
    public AudioClip harvestSound;
    public AudioClip buildSound;

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
        //myAgent.avoidancePriority = Random.Range(50, 100);
        AgentHandler.myDrones.Add(this);
	}
	
	// Update is called once per frame
	void Update ()
    {

        UpdateState();
        SpawnFootstep();
        ChangeAnimation();
	}

    public void UpdateState()
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
					ControllerVibrate.Vibrate(0.15f, 0.1f);
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
                        myDestination.harvestParticle.Play();
                        myDestination.harvested = true;
                        myDestination.gatherAnimator.SetActive(false);
                        myDestination.assignedTask = false;
                        myAudio.clip = harvestSound;
                        myAudio.Play();
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
                            myDestination.buildAnimator.SetActive(false);
                            myDestination.assignedTask = false;
							myDestination.CreateBuilding();
							myState = DroneState.Idle;
                            myAudio.clip = buildSound;
                            myAudio.Play();
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

		case DroneState.Demolish:
				if (Vector3.Distance (transform.position, buildingToDemolish.transform.position) > 1.0f) 
				{
					if (myAgent.destination != buildingToDemolish.transform.position)
					{
						myAgent.SetDestination(buildingToDemolish.transform.position);
					}
				} 

				else 
				{
					buildingToDemolish.TakeDamage (5);
					KillDrone ();
				}
				break;

            default:
                break;
        }
    }

	public void SetDestination(GroundBlocks destination)
	{
		myDestination = destination;
	}

	public void SetDestination(BuildingBlock destination)
	{
		buildingToDemolish = destination;
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
		ControllerVibrate.Vibrate(1, 0.5f);
        Instantiate(deathSound, transform.position, transform.rotation);
        Instantiate(deathParticle, transform.position, transform.rotation);
        AgentHandler.myDrones.Remove(this);
        if (myDestination != null)
        {
            myDestination.ResetOrder();
        }
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

    void ChangeAnimation()
    {
        if (isCarryingResource)
        {
            resourceAnimation.SetActive(true);
            walkAnimation.SetActive(false);
        }

        else
        {
            resourceAnimation.SetActive(false);
            walkAnimation.SetActive(true);
        }
    }
}
