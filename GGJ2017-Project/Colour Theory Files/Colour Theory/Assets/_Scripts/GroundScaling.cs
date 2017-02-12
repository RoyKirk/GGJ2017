using UnityEngine;
using System.Collections;

public class GroundScaling : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localScale -= new Vector3(Time.deltaTime * 0.01f,0, Time.deltaTime * 0.01f);
	}
}
