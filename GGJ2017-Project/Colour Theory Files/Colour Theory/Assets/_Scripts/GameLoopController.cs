using UnityEngine;
using System.Collections;

public class GameLoopController : MonoBehaviour
{
    public GameObject[] Players;
	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");
        if(Players.Length <= 1)
        {
            Application.LoadLevel(0);
        }
	}
}
