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

    public Material DefaultMat;
    public Material ScorchedMat;
    public Material HarvestedMat;

    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(currentResetTimer > 0)
        {
            currentResetTimer -= Time.deltaTime;
        }
        else
        {
            Depleted = false;
            GetComponent<Renderer>().material = DefaultMat;
        }

	    if(scorched)
        {
            if(MaxScorchedTimer > currentResetTimer)
            {
                currentResetTimer = MaxScorchedTimer;
                GetComponent<Renderer>().material = ScorchedMat;
            }
            scorched = false;
            Depleted = true;
        }

        if(harvested)
        {
            if(MaxHarvestTimer > currentResetTimer)
            {
                currentResetTimer = MaxHarvestTimer;
                GetComponent<Renderer>().material = HarvestedMat;
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
}


//block stuf

//can be harvested
//can be built on
//function to make building
//has building
//buildings need navmesh obstacle component