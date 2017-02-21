using UnityEngine;
using System.Collections;

public class DestroyObjects : MonoBehaviour
{
    public bool particle;
	// Use this for initialization
	void Start ()
    {
	
	}

    float autoDestructTimer = 1;
    float currentDestructTimer;

	// Update is called once per frame
	void Update ()
    {
	    if(particle)
        {
            //destroy self after X time
            currentDestructTimer += Time.deltaTime;

            if(currentDestructTimer >= autoDestructTimer)
            {
                Destroy(gameObject);
            }
        }

        if(transform.position.y <= -0.4f)
        {
            Destroy(gameObject);
        }
	}
}
