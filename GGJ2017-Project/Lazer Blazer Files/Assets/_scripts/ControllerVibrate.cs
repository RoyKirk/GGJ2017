using UnityEngine;
using System.Collections;
using XInputDotNetPure;

public class ControllerVibrate : MonoBehaviour 
{
	static float timer;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (timer <= 0) 
		{
			timer = 0;
			GamePad.SetVibration(PlayerIndex.One, 0, 0);
		}

		else 
		{
			timer -= Time.deltaTime;
		}
	}

	public static void Vibrate(float duration)
	{
		timer = duration;
		GamePad.SetVibration(PlayerIndex.One, 1, 1);
	}
}
