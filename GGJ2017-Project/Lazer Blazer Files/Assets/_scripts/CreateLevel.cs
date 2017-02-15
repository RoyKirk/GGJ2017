using UnityEngine;
using System.Collections;

public class CreateLevel : MonoBehaviour
{
	public GameObject[,] groundTiles;

    public int levelWidth = 20;
    public int levelHeight = 20;

    int widthCounter = 0;
    int heightCounter = 0;

    public GameObject ground;

	// Use this for initialization
	void Start ()
    {
		groundTiles = new GameObject[levelWidth, levelHeight];

        for (int x = widthCounter; x < levelWidth; x++)
        {
            for (int z = 0; z < levelHeight; z++)
            {
				groundTiles[x,z] = Instantiate(ground, new Vector3(widthCounter, 0, heightCounter), Quaternion.identity) as GameObject;
                heightCounter++;
            }
            heightCounter = 0;
            widthCounter++;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}


