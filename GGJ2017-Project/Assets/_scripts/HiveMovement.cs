using UnityEngine;
using System.Collections;

public class HiveMovement : MonoBehaviour
{
    public float speed = 0.2f;

    public bool left;
    public bool right;
    public bool up;
    public bool down;

    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKey(KeyCode.A) && !left)
        {
            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }


        //raycasts to detect collisions with walls

        RaycastHit hit;

        //left middle
        if(Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z), new Vector3(-1, 0, 0), out hit, 1.6f))
        {
            Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), new Vector3(-1, 0, 0));
            left = true;
            Debug.Log(hit.transform.name);
        }
        else
        {
            left = false;
        }

        //left top
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z + 1.5f), new Vector3(-1, 0, 0), out hit, 1.6f))
        {
            Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z + 1.5f), new Vector3(-1, 0, 0));
            left = true;
            Debug.Log(hit.transform.name);
        }
        else
        {
            left = false;
        }

        //left bottom
        if (Physics.Raycast(new Vector3(transform.position.x, transform.position.y + 1.5f, transform.position.z - 1.5f), new Vector3(-1, 0, 0), out hit, 1.6f))
        {
            Debug.DrawRay(new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), new Vector3(-1, 0, 0));
            left = true;
            Debug.Log(hit.transform.name);
        }
        else
        {
            left = false;
        }
    }
}
