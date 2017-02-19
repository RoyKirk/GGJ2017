using UnityEngine;
using System.Collections;

public class SlowFieldScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    Rigidbody Rb;

    public float slowVelocity;
    public float slowClamp;
    public float RapidSlow;

    Vector3 Initialvelocity;

    void OnTriggerEnter(Collider other)
    {
        if((Rb = other.GetComponent<Rigidbody>()) != null)
        {
            if (other.name == "RapidShot(Clone)")
            {
                Initialvelocity = Rb.velocity;
                Rb.velocity = Rb.velocity / RapidSlow;
                
            }
            else
            {
                Rb.velocity = Rb.velocity / slowVelocity;
                Initialvelocity = Rb.velocity;
            }
            
        }

        if (other.GetComponent<PlayerControllerNew>() != null)
        {
            other.GetComponent<PlayerControllerNew>().VelocityClamp /= slowClamp;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "RapidShot(Clone)")
        {

        }
        else if ((Rb = other.GetComponent<Rigidbody>()) != null)
        {
            Rb.velocity = Rb.velocity / slowVelocity;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "RapidShot(Clone)")
        {
            other.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 20000 * Time.deltaTime);
        }
        else if ((Rb = other.GetComponent<Rigidbody>()) != null)
        {
            //Rb.velocity = velocityClamp;
            if(other.GetComponent<PlayerControllerNew>() != null)
            {
                other.GetComponent<PlayerControllerNew>().VelocityClamp *= slowClamp;
            }
            else if ((Rb = other.GetComponent<Rigidbody>()) != null)
            {
                Rb.velocity = Initialvelocity;
            }
        }
    }
}
