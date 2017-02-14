using UnityEngine;
using System.Collections;

public class ReflectScript : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        Physics.IgnoreCollision(GetComponentInParent<Collider>(), GetComponent<Collider>());
    }
	
}

