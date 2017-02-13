using UnityEngine;
using System.Collections;
//using System;

public class LightningScript : MonoBehaviour
{
    /// <summary>
    /// need to add a sort of distances, and get the second closest target. maybe ask ewart if this is what he actually wants, and not a random target ect.
    /// need to make sure the list of players gets updated so that when a player dies it doesnt bug out.
    /// </summary>

    public float speed = 5;

    public GameObject[] Players;

    public float[] PlayerDistances;

    public int[] sortedElement;

    Rigidbody Rb;

    // Use this for initialization
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Players = GameObject.FindGameObjectsWithTag("Player");
        PlayerDistances = new float[Players.Length];
        sortedElement = new int[Players.Length];
        sortedElement[0] = 100;
        sortedElement[1] = 100;
        comparison = new float[4];
        elementPos = new int[2];
        Rb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime);
        thisCollider = GetComponent<Collider>();
    }

    bool colliderDeactive = false;
    public float ColliderDelay = 0.5f;
    float currentColliderDelay = 0;

    // Update is called once per frame
    void Update()
    {
        if(colliderDeactive == true)
        {
            currentColliderDelay += Time.deltaTime;
        }
        if(currentColliderDelay >= ColliderDelay)
        {
            colliderDeactive = false;
            thisCollider.enabled = true;
            currentColliderDelay = 0;
        }
        //move forward
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //Rb.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        Ray ray = new Ray(transform.position, fwd);

        if (Physics.Raycast(ray, out hit, 0.5f))
        {
            if (hit.transform.tag == "Projectile")
            {
                Destroy(gameObject);
            }
        }

        RayCastAllPlayers();
    }

    public float ExplosiveForce;
    public float Radius;

    Collider thisCollider;

    void OnCollisionStay(Collision c)
    {
        if (c.gameObject.tag == "Player")
        {
            thisCollider.enabled = false;
            colliderDeactive = true;
            c.rigidbody.AddExplosionForce(ExplosiveForce, transform.position, Radius);
            c.rigidbody.AddForce(Rb.velocity);
            transform.LookAt(Players[Random.Range(0, Players.Length)].transform);
            Rb.velocity = Vector3.zero;
            Rb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime);
        }
        else if (c.gameObject.tag == "Projectile")
        {
            Destroy(gameObject);
        }
    }
    

    void RayCastAllPlayers()
    {
        int x = 0;
        foreach (GameObject player in Players)
        {
            RaycastHit hit;

            Ray ray = new Ray(transform.position, player.transform.position - transform.position);
            Debug.DrawRay(transform.position, player.transform.position - transform.position);
            if (Physics.Raycast(ray, out hit, 1000))
            {
                PlayerDistances[x] = hit.distance;
                //Array.Sort(PlayerDistances);
                x++;
            }
        }
    }

    float[] comparison;
    int[] elementPos;

    void SortPlayers()
    {
        comparison[0] = PlayerDistances[0];
        comparison[1] = 100;

        for(int i = 1; i < PlayerDistances.Length; i++)
        {
            if(comparison[0] > PlayerDistances[i])
            {
                comparison[0] = PlayerDistances[i];
                elementPos[0] = i;
            }
        }

        for(int x = 0; x < PlayerDistances.Length; x++)
        {
            if(comparison[1] > PlayerDistances[x] && PlayerDistances[x] != comparison[0])
            {
                comparison[1] = PlayerDistances[x];
                elementPos[1] = x;
            }
            else
            {
                //comparison[1]
            }
        }
    }
}
