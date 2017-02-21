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

        //script new lasers

        //direction,colour,stregnth,speed,delay
        spawns.Add(new LaserSpawn(S, red, 2, 1, 15f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 30f));

        spawns.Add(new LaserSpawn(N, yellow, 2, 1, 60f));
        spawns.Add(new LaserSpawn(W, purple, 2, 1, 60f));

        spawns.Add(new LaserSpawn(E, red, 2, 1, 90f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 100f));
        spawns.Add(new LaserSpawn(E, red, 2, 1, 110f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 120f));

        spawns.Add(new LaserSpawn(N, yellow, 2, 1, 150f));
        spawns.Add(new LaserSpawn(W, purple, 2, 1, 160f));
        spawns.Add(new LaserSpawn(S, yellow, 2, 1, 170f));
        spawns.Add(new LaserSpawn(N, purple, 2, 1, 180f));
        spawns.Add(new LaserSpawn(W, yellow, 2, 1, 190f));
        spawns.Add(new LaserSpawn(S, purple, 2, 1, 200f));

        spawns.Add(new LaserSpawn(E, red, 2, 1, 230f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 240f));
        spawns.Add(new LaserSpawn(E, red, 2, 1, 250f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 260f));

        spawns.Add(new LaserSpawn(N, yellow, 2, 1, 300f));
        spawns.Add(new LaserSpawn(W, purple, 2, 1, 305f));
        spawns.Add(new LaserSpawn(S, yellow, 2, 1, 310f));
        spawns.Add(new LaserSpawn(N, purple, 2, 1, 315f));
        spawns.Add(new LaserSpawn(W, yellow, 2, 1, 320f));
        spawns.Add(new LaserSpawn(S, purple, 2, 1, 325f));

        spawns.Add(new LaserSpawn(E, red, 2, 1, 330f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 335f));
        spawns.Add(new LaserSpawn(E, red, 2, 1, 340f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 355f));
        spawns.Add(new LaserSpawn(E, red, 2, 1, 370f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 380f));
        spawns.Add(new LaserSpawn(E, red, 2, 1, 390f));
        spawns.Add(new LaserSpawn(E, blue, 2, 1, 400f));
        //level end





        foreach (LaserSpawn ls in spawns)
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
