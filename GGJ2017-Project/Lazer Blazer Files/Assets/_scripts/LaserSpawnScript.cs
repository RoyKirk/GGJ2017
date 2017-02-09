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


        spawns.Add(new LaserSpawn(E, purple, 1, 1, 15f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 30f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 35f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 40f));

        spawns.Add(new LaserSpawn(E, purple, 1, 1, 55f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 80f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 85f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 90f));


        spawns.Add(new LaserSpawn(E, purple, 1, 1, 105f));
        spawns.Add(new LaserSpawn(E, purple, 1, 1, 108f));
        spawns.Add(new LaserSpawn(E, purple, 1, 1, 111f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 130f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 133f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 136f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 135f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 138f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 141f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 140f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 143f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 146f));

        spawns.Add(new LaserSpawn(E, purple, 1, 1, 155f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 180f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 185f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 190f));

        spawns.Add(new LaserSpawn(E, purple, 1, 1, 205f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 230f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 235f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 240f));

        spawns.Add(new LaserSpawn(E, purple, 1, 1, 255f));
        spawns.Add(new LaserSpawn(E, purple, 1, 1, 258f));
        spawns.Add(new LaserSpawn(E, purple, 1, 1, 261f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 280f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 283f));
        spawns.Add(new LaserSpawn(S, blue, 1, 1, 286f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 285f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 288f));
        spawns.Add(new LaserSpawn(W, red, 1, 1, 291f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 290f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 293f));
        spawns.Add(new LaserSpawn(N, green, 1, 1, 296f));

        spawns.Add(new LaserSpawn(E, purple, 1, 1, 305f));
        //level end
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
