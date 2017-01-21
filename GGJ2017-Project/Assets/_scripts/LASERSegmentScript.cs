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
    float deathTime = 10.0f;
    float deathTimer = 0.0f;


    // Use this for initialization
    void Start () {

        GetComponent<MeshRenderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        delayTimer += Time.deltaTime;
        if (delayTimer >= delay)
        {
            deathTimer += Time.deltaTime;
            if(deathTimer >= deathTime)
            {
                Destroy(gameObject.transform.parent.gameObject);
            }
            GetComponent<MeshRenderer>().enabled = true;
            if (dir == Direction.NORTH)
            {
                transform.position += new Vector3(0, 0, 5) * speed * Time.deltaTime;
            }
            if (dir == Direction.SOUTH)
            {
                transform.position += new Vector3(0, 0, -5) * speed * Time.deltaTime;
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
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        if (other.tag == "laser")
        {
            Destroy(other.gameObject);
            //Destroy(gameObject);
        }

    }
}
