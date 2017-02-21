using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

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
    float deathTime = 300.0f;
    float deathTimer = 0.0f;

    bool appear = false;

    public AudioSource myAudio;

    // Use this for initialization
    void Start ()
    {
        myAudio = GetComponentInParent<AudioSource>();
        foreach (Transform child in transform)
        {
            child.GetComponent<MeshRenderer>().enabled = false;
        }


            GetComponent<MeshRenderer>().enabled = false;
	}


    // Update is called once per frame
    void Update () {
        foreach (Transform child in transform)
        {
            if (col == Colour.GREEN)
            {
                child.gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.green);
            }
            if (col == Colour.RED)
            {
                child.gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.red);
            }
            if (col == Colour.BLUE)
            {
                child.gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.blue);
            }
            if (col == Colour.YELLOW)
            {
                child.gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.yellow);
            }
            if (col == Colour.PURPLE)
            {
                child.gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.magenta);
            }
        }

        if (col == Colour.GREEN)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.green);
        }
        if (col == Colour.RED)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.red);
        }
        if (col == Colour.BLUE)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.blue);
        }
        if (col == Colour.YELLOW)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.yellow);
        }
        if (col == Colour.PURPLE)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_GlowColor", Color.magenta);
        }



        delayTimer += Time.deltaTime;
        if (delayTimer >= delay)
        {
            deathTimer += Time.deltaTime;
            if(deathTimer >= deathTime)
            {
                Destroy(gameObject.transform.parent.gameObject);
            }
            RaycastHit hit;

            if (Physics.Raycast(transform.position, new Vector3(0, -1, 0), out hit, 1.0f))
            {
                Debug.DrawRay(transform.position, new Vector3(0, -1, 0));
                CollisionChecks(hit.collider);
            }
            else if (Physics.Raycast(transform.position + new Vector3(-0.45f, 0, 0), new Vector3(0, -1, 0), out hit, 1.0f))
            {
                Debug.DrawRay(transform.position, new Vector3(-0.45f, 0, 0));
                CollisionChecks(hit.collider);
            }
            else if (Physics.Raycast(transform.position + new Vector3(0.45f, 0, 0), new Vector3(0, -1, 0), out hit, 1.0f))
            {
                Debug.DrawRay(transform.position, new Vector3(0.45f, 0, 0));
                CollisionChecks(hit.collider);
            }
            else if (Physics.Raycast(transform.position + new Vector3(0, 0, -0.45f), new Vector3(0, -1, 0), out hit, 1.0f))
            {
                Debug.DrawRay(transform.position, new Vector3(0, 0, -0.45f));
                CollisionChecks(hit.collider);
            }
            else if (Physics.Raycast(transform.position + new Vector3(0, 0, 0.45f), new Vector3(0, -1, 0), out hit, 1.0f))
            {
                Debug.DrawRay(transform.position, new Vector3(0, 0, 0.45f));
                CollisionChecks(hit.collider);
            }


            if (!appear)
            {
                foreach (Transform child in transform)
                {
                    child.GetComponent<MeshRenderer>().enabled = true;
                }
                GetComponent<MeshRenderer>().enabled = true;
                appear = true;
            }
            

            if (dir == Direction.NORTH)
            {
                if (Physics.Raycast(transform.position, new Vector3(0,0,1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(-0.45f,0,0), new Vector3(0, 0, 1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(0.45f, 0, 0), new Vector3(0, 0, 1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
            }
            if (dir == Direction.SOUTH)
            {
                if (Physics.Raycast(transform.position, new Vector3(0, 0, -1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(-0.45f, 0, 0), new Vector3(0, 0, -1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(0.45f, 0, 0), new Vector3(0, 0, -1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(0, 0, -1) * speed * Time.deltaTime;
            }
            if (dir == Direction.EAST)
            {
                if (Physics.Raycast(transform.position, new Vector3(1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(0, 0, -0.45f), new Vector3(1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(0, 0, 0.45f), new Vector3(1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            }
            if (dir == Direction.WEST)
            {
                if (Physics.Raycast(transform.position, new Vector3(-1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(0, 0, -0.45f), new Vector3(-1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                else if (Physics.Raycast(transform.position + new Vector3(0, 0, 0.45f), new Vector3(-1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
            }
        }

	
	}

    //all destruction and function calls
    private void CollisionChecks(Collider collider)
    {
        if (collider.tag == "laser")
        {
            //Destroy(collider.gameObject);
            //Destroy(gameObject);
        }
       // if (collider.tag == "Drone")
       // {
       //     collider.gameObject.GetComponent<Drone>().KillDrone();
      //  }
        if (collider.tag == "Building")
        {
            collider.gameObject.GetComponent<BuildingBlock>().TakeDamage((float)strength);

            foreach (Transform child in transform)
            {
                Destroy(child.gameObject);
            }
            Destroy(gameObject);
            myAudio.Play();
        }
        if (collider.tag == "Ground")
        {
            collider.gameObject.GetComponent<GroundBlocks>().scorched = true;
        }
        if (collider.tag == "Hive")
        {
            GameObject.Find("Camera").GetComponent<ScreenShakeScript>().Shake();
            Destroy(collider.gameObject);
			ControllerVibrate.Vibrate(0.3f, 0.3f);
            GameObject.Find("Camera").GetComponent<ScreenShakeScript>().DefeatScreen.SetActive(true);
            //StartCoroutine(RestartLevel());

            //Destroy(gameObject);
        }

    }
    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(3f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("royMenu");
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
