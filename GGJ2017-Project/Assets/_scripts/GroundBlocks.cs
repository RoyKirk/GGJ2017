using UnityEngine;
using System.Collections;

public class GroundBlocks : MonoBehaviour
{

    public bool Depleted;//check this to see if you can harvest it

    
    public bool harvested;//set this to true when you actually harvest it
    public bool scorched;//set this when a lazer scorches it
    public bool canBuildOn;//check this to see if you can build on the block

    public bool assignedTask;//change this when you set a task to a block, then check when setting a task.

    public float MaxScorchedTimer = 10;
    public float MaxHarvestTimer = 5;

    public float currentResetTimer = 0;

    public GameObject BuildingBlock;
    public Drone myAssignedDrone;

    Material Mat;

    public Material DefaultMat;
    public Material ScorchedMat;
    public Material HarvestedMat;
    public Material FlashMat;

    //flash variables
    public int timesFlashed;
    public float durationOfFlash;
    public float currentFlashDuration;
    public float timeBetweenFlash;
    public float currentTimeBetweenFlash;


    //times flashed
    //duration of flash
    //time between flash

    // Use this for initialization
    void Start ()
    {
        Mat = GetComponent<Renderer>().material;

    }
	
	// Update is called once per frame
	void Update ()
    {

        if (currentResetTimer > 0)
        {
            currentResetTimer -= Time.deltaTime;
            Flash(DefaultMat);
            Mat = DefaultMat;
        }
        else
        {
            Depleted = false;
            
            //Mat = DefaultMat;
        }

	    if(scorched)
        {
            if(MaxScorchedTimer > currentResetTimer)
            {
                currentResetTimer = MaxScorchedTimer;
                Mat = ScorchedMat;
            }
            scorched = false;
            Depleted = true;
        }

        if(harvested)
        {
            if(MaxHarvestTimer > currentResetTimer)
            {
                currentResetTimer = MaxHarvestTimer;
                Mat = HarvestedMat;
                //Flash(HarvestedMat);
            }
            harvested = false;
            Depleted = true;
        }

	}

    public void CreateBuilding()
    {
        //instantiate a block on top of this one. 
        //change Has building bool.
        Instantiate(BuildingBlock, new Vector3(transform.position.x, 1, transform.position.z), Quaternion.identity);
        canBuildOn = false;
    }

    public void CancelOrder()
    {
        assignedTask = false;
        myAssignedDrone.CancelOrder();
        myAssignedDrone = null;
    }

    void Flash(Material resultMat)
    {
        //times flashed
        //duration of flash
        //time between flash

        //for (int i = 0; i < timesFlashed; i++)
        //{
        //    
        //    if(currentFlashDuration > 0)
        //    {
        //        currentFlashDuration -= Time.deltaTime;
        //        Mat = FlashMat;
        //    }
        //    else
        //    {
        //        Mat = resultMat;
        //    }
        //}

        if (currentFlashDuration > 0)
        {
            currentFlashDuration -= Time.deltaTime;
            Mat = FlashMat;
        }
        else if(currentTimeBetweenFlash > 0)
        {
            currentTimeBetweenFlash -= Time.deltaTime;
            Mat = resultMat;
        }
        else if(currentFlashDuration <= 0)
        {
            currentTimeBetweenFlash = timeBetweenFlash;
        }
        else if(currentTimeBetweenFlash <= 0)
        {
            currentFlashDuration = durationOfFlash;
        }
        



    }
}


//block stuf

//can be harvested
//can be built on
//function to make building
//has building
//buildings need navmesh obstacle component