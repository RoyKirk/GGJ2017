using UnityEngine;
using System.Collections;

public class BuildingBlock : MonoBehaviour
{
    public float health;

    public GroundBlocks myLocation;

    public GameObject explosion;

    public GameObject MaterialHolder;

	NavMeshObstacle m_obstacle;
	public float colliderDelay;
	float colliderTimer;

	public GameObject material;

	public bool toBeDemolished = false;

    bool vaporise = false;

	// Use this for initialization
	void Start () 
	{
		m_obstacle = GetComponent<NavMeshObstacle> ();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (m_obstacle.enabled == false) 
		{
			ActivateObstacle ();
		}

        if(vaporise)
        {
            if (MaterialHolder.GetComponent<MeshRenderer>().material.GetFloat("_DissolveAmount") < 1.0f)
            {
                MaterialHolder.GetComponent<MeshRenderer>().material.SetFloat("_DissolveAmount", MaterialHolder.GetComponent<MeshRenderer>().material.GetFloat("_DissolveAmount") + Time.deltaTime);
            }
            else
            {
                GameObject.Find("Camera").GetComponent<ScreenShakeScript>().Shake();

                myLocation.canBuildOn = true;
                Destroy(this.gameObject);
            }
        }
    }

    public void TakeDamage(float damage)
	{
		ControllerVibrate.Vibrate(1);
        health -= damage;
		material.GetComponent<Renderer>().material.color = Color.red;
        Instantiate(explosion, new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z), Quaternion.Euler(new Vector3(90,0,0)));
        if (health <= 0)
        {
            vaporise = true;
        }
    }

	void ActivateObstacle()
	{
		if (colliderTimer < colliderDelay) 
		{
			colliderTimer += Time.deltaTime;
		} 

		else 
		{
			m_obstacle.enabled = true;
		}
	}
}

//when destroyed change bool of HasBuilding of block below this building.

//buildings need navmesh obstacle component


//can be harvested
//can be built on
//function to make building
//has building