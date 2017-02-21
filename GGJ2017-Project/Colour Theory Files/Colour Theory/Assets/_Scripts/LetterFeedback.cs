using UnityEngine;
using System.Collections;

public class LetterFeedback : MonoBehaviour
{
    public bool animate;
	// Use this for initialization
	void Start ()
    {
	
	}


    bool expand = true;

    float increment;

    Vector3 scaleMod = new Vector3(0, 10, 0);

	// Update is called once per frame
	void Update ()
    {
	    if(animate)
        {
            if(expand)
            {
                //transform.localScale += new Vector3(0, 1, 0) * Time.deltaTime;
            }
            else
            {
                transform.localScale += new Vector3(0, -1, 0) * Time.deltaTime;
            }
            
        }
	}
}
