﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LaserSpawnScript : LASERSegmentScript {


    const Direction W = Direction.WEST;
    const Direction E = Direction.EAST;
    const Direction S = Direction.SOUTH;
    const Direction N = Direction.NORTH;

    const Colour red = Colour.RED;
    const Colour yellow = Colour.YELLOW;
    const Colour green = Colour.GREEN;
    const Colour purple = Colour.PURPLE;
    const Colour blue = Colour.BLUE;

    public GameObject EastLaser;
    public GameObject WestLaser;
    public GameObject SouthLaser;
    public GameObject NorthLaser;



    class LaserSpawn
    {
        public Direction dir;
        public Colour col;
        public float strength;
        public float speed;
        public float delay;
        public LaserSpawn(Direction dir, Colour col, float strength, float speed, float delay)
        {
            this.dir = dir;
            this.col = col;
            this.strength = strength;
            this.speed = speed;
            this.delay = delay;
        }
    }

    List<LaserSpawn> spawns = new List<LaserSpawn>();

    // Use this for initialization
	void Start () {
        spawns.Add(new LaserSpawn(W, yellow, 1, 1, 20));
        spawns.Add(new LaserSpawn(E, red, 1, 2, 25));
        spawns.Add(new LaserSpawn(S, blue, 1, 3, 20));
        spawns.Add(new LaserSpawn(N, purple, 1, 1, 30));
        spawns.Add(new LaserSpawn(E, green, 1, 2, 35));


        foreach(LaserSpawn ls in spawns)
        {
            if(ls.dir == W)
            {
                GameObject temp = Instantiate(WestLaser);
                LASERSegmentScript[] lasers = temp.GetComponentsInChildren<LASERSegmentScript>();
                foreach (LASERSegmentScript laserSeg in lasers)
                {
                    laserSeg.dir = ls.dir;
                    laserSeg.col = ls.col;
                    laserSeg.strength = ls.strength;
                    laserSeg.speed = ls.speed;
                    laserSeg.delay = ls.delay;
                }
            }
            if (ls.dir == E)
            {
                GameObject temp = Instantiate(EastLaser);
                LASERSegmentScript[] lasers = temp.GetComponentsInChildren<LASERSegmentScript>();
                foreach (LASERSegmentScript laserSeg in lasers)
                {
                    laserSeg.dir = ls.dir;
                    laserSeg.col = ls.col;
                    laserSeg.strength = ls.strength;
                    laserSeg.speed = ls.speed;
                    laserSeg.delay = ls.delay;
                }
            }
            if (ls.dir == S)
            {
                GameObject temp = Instantiate(SouthLaser);
                LASERSegmentScript[] lasers = temp.GetComponentsInChildren<LASERSegmentScript>();
                foreach (LASERSegmentScript laserSeg in lasers)
                {
                    laserSeg.dir = ls.dir;
                    laserSeg.col = ls.col;
                    laserSeg.strength = ls.strength;
                    laserSeg.speed = ls.speed;
                    laserSeg.delay = ls.delay;
                }
            }
            if (ls.dir == N)
            {
                GameObject temp = Instantiate(NorthLaser);
                LASERSegmentScript[] lasers = temp.GetComponentsInChildren<LASERSegmentScript>();
                foreach (LASERSegmentScript laserSeg in lasers)
                {
                    laserSeg.dir = ls.dir;
                    laserSeg.col = ls.col;
                    laserSeg.strength = ls.strength;
                    laserSeg.speed = ls.speed;
                    laserSeg.delay = ls.delay;
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {


	
	}
}
