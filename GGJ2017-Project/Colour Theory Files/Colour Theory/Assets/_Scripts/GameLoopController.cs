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
        //Players = GameObject.FindGameObjectsWithTag("Player");
        //if(Players.Length <= 1)
        //{
        //    Application.LoadLevel(1);
        //}

        for(int i = 0; i < Controller.connected.Length; i++)
        {
            if(Controller.state[i].Buttons.Start == XInputDotNetPure.ButtonState.Pressed && Controller.connected[i] == true)
            {
                Application.LoadLevel(0);
            }
            if(Controller.state[i].Buttons.Back == XInputDotNetPure.ButtonState.Pressed && Controller.connected[i] == true)
            {
                Application.LoadLevel(1);
            }
        }
	}
}
