using UnityEngine;
using System.Collections;

public class GroundBlocks : MonoBehaviour
{
    public bool Depleted;//check this to see if you can harvest it

    
    public bool harvested;//set this to true when you actually harvest it
    public bool scorched;//set this when a lazer scorches it
    public bool canBuildOn;//check this to see if you can build on the block

	public bool assignedTask;//change this when you set a task to a block, then check when setting a task.
	public bool isBuildOrder; //indicates that this block is part of the buildOrders list
	public bool isDigOrder; //indicates that this block is part of the digOrders list

    public float MaxScorchedTimer = 10;
    public float MaxHarvestTimer = 5;

    public float currentResetTimer = 0;

    public GameObject BuildingBlock;
    public GameObject buildAnimator;
    public GameObject gatherAnimator;
    public GameObject cancelAnimator;
    public GameObject flashAnimator;

    public GameObject groundTexture;

    public Drone myAssignedDrone;
    public ParticleSystem harvestParticle;
    public ParticleSystem buildParticle;

    Material Mat;
    public GameObject MaterialHolder;

    //public Material DefaultMat;
    //public Material highlightedMat;
    //public Material ScorchedMat;
    //public Material HarvestedMat;
    //public Material FlashMat;

    //flash variables
    public int timesFlashed;
    public float durationOfFlash;
    public float currentFlashDuration;
    public float timeBetweenFlash;
    public float currentTimeBetweenFlash;
    bool flashing = false;


    bool vaporise = false;

    //times flashed
    //duration of flash
    //time between flash

    // Use this for initialization
    void Start ()
    {
        Mat = MaterialHolder.GetComponent<MeshRenderer>().material;
        //flashing = true;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Flash();
        Highlight();

        if (currentResetTimer >= 0)
        {
            currentResetTimer -= Time.deltaTime;
            //Flash(DefaultMat);
            //GetComponent<Renderer>().material = HarvestedMat;
            //currentFlashDuration = durationOfFlash;
        }
        else if (Depleted)
        {
            if (Mat.GetFloat("_DissolveAmount") > 0.0f)
            {
                Mat.SetFloat("_DissolveAmount", Mat.GetFloat("_DissolveAmount") - 0.5f * Time.deltaTime);
                Mat.SetColor("_Highlighted", new Vector4(0.05F,0,0.05f,1.0f));
            }
            else
            {
                Mat.SetColor("_Highlighted", Color.black);
                Depleted = false;
            }
            //GetComponent<Renderer>().material = DefaultMat;
            //flashAnimator.SetActive(true);
            //Mat = DefaultMat;
        }

        if(scorched)
        {
            if(MaxScorchedTimer > currentResetTimer)
            {
                currentResetTimer = MaxScorchedTimer;
                //Mat = ScorchedMat;
            }
			CancelOrder ();

            vaporise = true;
            scorched = false;
            Depleted = true;
            //shader dissolve slider hook
            //Mat.SetFloat("_DissolveAmount", Mat.GetFloat("_DissolveAmount") + 0.1f * Time.deltaTime);
        }

        if(vaporise)
        {
            if (Mat.GetFloat("_DissolveAmount") < 1.0f)
            {
                Mat.SetFloat("_DissolveAmount", Mat.GetFloat("_DissolveAmount") + 0.5f * Time.deltaTime);
                Mat.SetColor("_Highlighted", new Vector4(0.05f, 0.025f, 0, 1.0f));
            }
            else
            {
                vaporise = false;
                Mat.SetColor("_Highlighted", Color.black); 
            }
        }

        if(harvested)
        {
            if(MaxHarvestTimer > currentResetTimer)
            {
                currentResetTimer = MaxHarvestTimer;
                //Mat = HarvestedMat;
                currentFlashDuration = durationOfFlash;
                //Flash(HarvestedMat);
            }
            Mat.SetFloat("_DissolveAmount", 1.0f);
            harvested = false;
            Depleted = true;
        }

	}

    public void CreateBuilding()
    {
        //instantiate a block on top of this one. 
        //change Has building bool.
        BuildingBlock newBuilding;
        GameObject tempBuilding = (GameObject)Instantiate(BuildingBlock, new Vector3(transform.position.x, 1, transform.position.z), Quaternion.identity);
        newBuilding = tempBuilding.GetComponent<BuildingBlock>();
        newBuilding.myLocation = this;
        buildParticle.Play();
        canBuildOn = false;
    }

    public void CancelOrder()
    {
        assignedTask = false;
        buildAnimator.SetActive(false);
        gatherAnimator.SetActive(false);
        if (myAssignedDrone != null)
        {
            myAssignedDrone.CancelOrder();
            myAssignedDrone = null;
        }
    }

    public void ResetOrder()
    {
        myAssignedDrone = null;

        if (buildAnimator.activeInHierarchy)
        {
            AgentHandler.buildOrders.Add(this);
        }

        else if (gatherAnimator.activeInHierarchy)
        {
            AgentHandler.digOrders.Add(this);
        }
    }

    //void Flash(Material resultMat)
    //{
    //    if(currentFlashDuration > 0)
    //    {
    //        Mat = FlashMat;
            
    //    }
    //    else
    //    {
    //        Mat = DefaultMat;
    //    }
    //    currentFlashDuration -= Time.deltaTime;

    //    //times flashed
    //    //duration of flash
    //    //time between flash

    //    //for (int i = 0; i < timesFlashed; i++)
    //    //{
    //    //    
    //    //    if(currentFlashDuration > 0)
    //    //    {
    //    //        currentFlashDuration -= Time.deltaTime;
    //    //        Mat = FlashMat;
    //    //    }
    //    //    else
    //    //    {
    //    //        Mat = resultMat;
    //    //    }
    //    //}

    //    //if (currentFlashDuration > 0)
    //    //{
    //    //    currentFlashDuration -= Time.deltaTime;
    //    //    Mat = FlashMat;
    //    //}
    //    //else if(currentTimeBetweenFlash > 0)
    //    //{
    //    //    currentTimeBetweenFlash -= Time.deltaTime;
    //    //    Mat = resultMat;
    //    //}
    //    //else if(currentFlashDuration <= 0)
    //    //{
    //    //    currentTimeBetweenFlash = timeBetweenFlash;
    //    //}
    //    //else if(currentTimeBetweenFlash <= 0)
    //    //{
    //    //    currentFlashDuration = durationOfFlash;
    //    //}
    //}

    void Highlight()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100f))
        {
            if (hit.transform.gameObject.GetComponent<GroundBlocks>() == this)
            {
                Mat.SetColor("_Highlighted", new Vector4(0.1f,0.1f,0.1f,1.0f));
            }
            else
            {
                Mat.SetColor("_Highlighted", Color.black);
            }
        }
        else
        {
            Mat.SetColor("_Highlighted", Color.black);
        }

        //if (Depleted)
        //{
        //    groundTexture.GetComponent<Renderer>().material = HarvestedMat;

        //    RaycastHit hit;
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, out hit, 100f))
        //    {
        //        if (hit.transform.gameObject.GetComponent<GroundBlocks>() == this)
        //        {
        //            groundTexture.GetComponent<Renderer>().material = ScorchedMat;
        //        }
        //    }
        //}

        //else
        //{
        //    groundTexture.GetComponent<Renderer>().material = DefaultMat;

        //    RaycastHit hit;
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //    if (Physics.Raycast(ray, out hit, 100f))
        //    {
        //        if (hit.transform.gameObject.GetComponent<GroundBlocks>() == this)
        //        {
        //            groundTexture.GetComponent<Renderer>().material = highlightedMat;
        //        }
        //    }
        //}
    }
}


//block stuf

//can be harvested
//can be built on
//function to make building
//has building
//buildings need navmesh obstacle component