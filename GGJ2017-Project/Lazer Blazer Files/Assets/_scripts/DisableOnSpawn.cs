using UnityEngine;
using System.Collections;

public class DisableOnSpawn : MonoBehaviour
{
    public float timer;
    float myTimer;
	
	// Update is called once per frame
	void Update ()
    {
        myTimer += Time.deltaTime;
        if (myTimer >= timer)
        {
            myTimer = 0;
            this.gameObject.SetActive(false);
        }
	}
}
