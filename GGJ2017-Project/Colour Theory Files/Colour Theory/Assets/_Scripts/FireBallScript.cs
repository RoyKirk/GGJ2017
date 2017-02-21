using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour
{
    public float speed = 5;

    public float DestructionTimer = 3f;
    float currentDestructionTimer = 0;

    public Collider playerCollider;

    Rigidbody Rb;

    public GameObject particleExplosion;

	// Use this for initialization
	void Start ()
    {
        Rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //move forward
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        Rb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime);

        //destroy after time
        currentDestructionTimer += Time.deltaTime;
        if(currentDestructionTimer >= DestructionTimer)
        {
            Destroy(gameObject);
        }
        else if(currentDestructionTimer >= 0.75f)
        {
            Physics.IgnoreCollision(GetComponent<Collider>(), playerCollider, false);
        }

        
	}
    private Vector3 oldVelocity;
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        oldVelocity = Rb.velocity;
        //RaycastHit hit;
        //
        //Ray ray = new Ray(transform.position, fwd);
        //
        //if (Physics.Raycast(ray,out hit, 0.5f))
        //{
        //    if(hit.transform.tag == "Projectile")
        //    {
        //        Destroy(gameObject);
        //    }
        //}
    }

    public float ExplosiveForce;
    public float Radius;

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.tag == "Player" || c.gameObject.tag == "Object")
        {
            if (c.gameObject.GetComponent<PlayerControllerNew>() != null)
            {
                c.gameObject.GetComponent<PlayerControllerNew>().Vibration();
            }
            if(c.rigidbody != null)
            {
                //Debug.Log("hit player");
                c.rigidbody.AddExplosionForce(ExplosiveForce, transform.position, Radius);
                //c.rigidbody.AddExplosionForce(ExplosiveForce, Rb.velocity, Radius);
                c.rigidbody.AddForce(Rb.velocity / 2);// + transform.rotation.eulerAngles);
                                                  //c.rigidbody.AddForce(c.impulse);
                                                  //c.rigidbody.velocity += Rb.velocity;
                
            }
            Instantiate(particleExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (c.gameObject.tag == "Projectile")
        {
            Instantiate(particleExplosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (c.gameObject.tag == "Reflect")
        {
            Instantiate(particleExplosion, transform.position, transform.rotation);
            // get the point of contact
            ContactPoint contact = c.contacts[0];

            // reflect our old velocity off the contact point's normal vector
            Vector3 reflectedVelocity = Vector3.Reflect(oldVelocity, contact.normal);

            // assign the reflected velocity back to the rigidbody
            Rb.velocity = reflectedVelocity;
            // rotate the object by the same ammount we changed its velocity
            Quaternion rotation = Quaternion.FromToRotation(oldVelocity, reflectedVelocity);
            transform.rotation = rotation * transform.rotation;
        }
    }
}
