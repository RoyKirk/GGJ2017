using UnityEngine;
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
        Direction dir;
        Colour col;
        float strength;
        float speed;
        float delay;
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
        spawns.Add(new LaserSpawn(W, yellow, 1, 1, 1));
        spawns.Add(new LaserSpawn(E, red, 1, 1, 2));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 3));
        spawns.Add(new LaserSpawn(N, purple, 1, 1, 4));
        spawns.Add(new LaserSpawn(E, green, 1, 1, 5));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
