using UnityEngine;
using System.Collections;

public class CreateLevel : MonoBehaviour
{
    
    public int levelWidth = 20;
    public int levelHeight = 20;

    int widthCounter = 0;
    int heightCounter = 0;

    float seperationX = 0;
    float seperationZ = 0;

    public float sperationAmount = 0.5f;

    public GameObject ground;

	// Use this for initialization
	void Start ()
    {
        for (int x = widthCounter; x < levelWidth; x++)
        {
            for (int z = 0; z < levelHeight; z++)
            {
                Instantiate(ground, new Vector3(widthCounter + seperationX, 0, heightCounter + seperationZ), Quaternion.identity);
                seperationZ += sperationAmount;
                heightCounter++;
            }
            seperationZ = 0;
            heightCounter = 0;
            seperationX += sperationAmount;
            widthCounter++;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}
}


