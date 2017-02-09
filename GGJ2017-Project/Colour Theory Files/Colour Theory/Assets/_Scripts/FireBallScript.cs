﻿using UnityEngine;
using System.Collections;

public class FireBallScript : MonoBehaviour
{
    public float speed = 5;

    public float DestructionTimer = 3f;
    float currentDestructionTimer = 0;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        //move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //destroy after time
        currentDestructionTimer += Time.deltaTime;
        if(currentDestructionTimer >= DestructionTimer)
        {
            Destroy(gameObject);
        }

        
	}

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        Ray ray = new Ray(transform.position, fwd);

        if (Physics.Raycast(ray,out hit, 0.5f))
        {
            if(hit.transform.tag == "Projectile")
            {
                Destroy(gameObject);
            }
        }
    }

    public float ExplosiveForce;
    public float Radius;

    void OnCollisionStay(Collision c)
    {
        if(c.gameObject.tag == "Player")
        {
            Debug.Log("hit player");
            c.rigidbody.AddExplosionForce(ExplosiveForce, transform.position, Radius);
            Destroy(gameObject);
        }
    }
}