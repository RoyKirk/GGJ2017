using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonutHole : MonoBehaviour
{
    public float sizeScale = 1;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameObject.transform.localScale += new Vector3(((Time.deltaTime * 0.01f) + 0.001f) / sizeScale, 0, ((Time.deltaTime * 0.01f) + 0.001f )/ sizeScale);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
