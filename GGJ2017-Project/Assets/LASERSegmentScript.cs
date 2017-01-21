using UnityEngine;
using System.Collections;

public class LASERSegmentScript : MonoBehaviour {

    public enum Direction
    {
        NORTH,
        EAST,
        WEST,
        SOUTH,

    }

    public enum Colour
    {
        RED,
        GREEN,
        BLUE,
        PURPLE,
        YELLOW,
    }


    public Direction dir = Direction.WEST;
    public Colour col = Colour.RED;
    public float strength = 1.0f;
    public float speed = 1.0f;
    public float delay = 1.0f;
    public float delayTimer = 0.0f;


    // Use this for initialization
    void Start () {
       
	
	}
	
	// Update is called once per frame
	void Update () {

        delayTimer += Time.deltaTime;
        if (delayTimer >= delay)
        {
            if (dir == Direction.NORTH)
            {
                transform.position += new Vector3(0, -5, 0) * speed * Time.deltaTime;
            }
            if (dir == Direction.SOUTH)
            {
                transform.position += new Vector3(0, 5, 0) * speed * Time.deltaTime;
            }
            if (dir == Direction.EAST)
            {
                transform.position += new Vector3(5, 0, 0) * speed * Time.deltaTime;
            }
            if (dir == Direction.WEST)
            {
                transform.position += new Vector3(-5, 0, 0) * speed * Time.deltaTime;
            }
        }

	
	}
}
