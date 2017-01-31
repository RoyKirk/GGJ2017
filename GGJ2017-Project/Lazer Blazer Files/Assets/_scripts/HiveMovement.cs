using UnityEngine;
using System.Collections;

public class HiveMovement : MonoBehaviour
{
    public float speed = 0.2f;
    Vector3 velocity;
    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        //
        // CONTROLLER INPUTS
        //

        velocity = Vector3.zero;
        velocity.x = (Input.GetAxis("L_XAxis_1"));
        velocity.z = (Input.GetAxis("L_YAxis_1"));
        velocity = velocity.normalized * speed;
        transform.position += velocity * Time.deltaTime;
        
        //
        // KEYBOARD INPUTS
        //

	    if(Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - (speed * Time.deltaTime), transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + (speed * Time.deltaTime), transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (speed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (speed * Time.deltaTime));
        }
        
    }
}
