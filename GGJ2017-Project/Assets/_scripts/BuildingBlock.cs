using UnityEngine;
using System.Collections;

public class BuildingBlock : MonoBehaviour
{
    public int health;

    public GroundBlocks myLocation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            GameObject.Find("Camera").GetComponent<ScreenShakeScript>().Shake();

            myLocation.canBuildOn = true;
            Destroy(this.gameObject);
        }
    }
}

//when destroyed change bool of HasBuilding of block below this building.

//buildings need navmesh obstacle component


//can be harvested
//can be built on
//function to make building
//has building