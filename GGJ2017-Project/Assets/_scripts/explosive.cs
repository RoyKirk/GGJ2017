using UnityEngine;
using System.Collections;

public class explosive : MonoBehaviour
{

    public float MaxDuration;
    float duration;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        duration += Time.deltaTime;

        if(duration >= MaxDuration)
        {
            Destroy(gameObject);
        }
	}
}
