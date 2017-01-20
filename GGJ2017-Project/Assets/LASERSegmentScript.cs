using UnityEngine;
using System.Collections;

public class LASERSegmentScript : MonoBehaviour {

    enum Direction
    {
        NORTH,
        EAST,
        WEST,
        SOUTH,

    }

    Direction dir = Direction.WEST;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(dir == Direction.WEST)
        {
            transform.position += new Vector3(5,0,0) * Time.deltaTime;
        }
	
	}
}
