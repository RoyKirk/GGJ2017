using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnPositions;
    public GameObject[] laser;


    public float MAX_SPAWN_DELAY = 0.5f;
    float currentDelay = 0;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentDelay += Time.deltaTime;

        if(currentDelay >= MAX_SPAWN_DELAY)
        {
            int ranPos = Random.Range(0, 4);
            int ranLaser = Random.Range(0, 2);

            Instantiate(laser[ranLaser], spawnPositions[ranPos].transform.position, spawnPositions[ranPos].transform.rotation);
            currentDelay = 0;
        }
	}
}
