﻿using UnityEngine;
using System.Collections;
using System;

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
    float deathTime = 20.0f;
    float deathTimer = 0.0f;


    // Use this for initialization
    void Start () {

        GetComponent<MeshRenderer>().enabled = false;
	}


    // Update is called once per frame
    void Update () {

        if (col == Colour.GREEN)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        if (col == Colour.RED)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (col == Colour.BLUE)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (col == Colour.YELLOW)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        }
        if (col == Colour.PURPLE)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.magenta;
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

            GetComponent<MeshRenderer>().enabled = true;
            if (dir == Direction.NORTH)
            {
                if (Physics.Raycast(transform.position, new Vector3(0,0,1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(0, 0, 5) * speed * Time.deltaTime;
            }
            if (dir == Direction.SOUTH)
            {
                if (Physics.Raycast(transform.position, new Vector3(0, 0, -1), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(0, 0, -5) * speed * Time.deltaTime;
            }
            if (dir == Direction.EAST)
            {
                if (Physics.Raycast(transform.position, new Vector3(1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(5, 0, 0) * speed * Time.deltaTime;
            }
            if (dir == Direction.WEST)
            {
                if (Physics.Raycast(transform.position, new Vector3(-1, 0, 0), out hit, 1.0f))
                {
                    CollisionChecks(hit.collider);
                }
                transform.position += new Vector3(-5, 0, 0) * speed * Time.deltaTime;
            }
        }

	
	}

    private void CollisionChecks(Collider collider)
    {
        if (collider.tag == "laser")
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
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
