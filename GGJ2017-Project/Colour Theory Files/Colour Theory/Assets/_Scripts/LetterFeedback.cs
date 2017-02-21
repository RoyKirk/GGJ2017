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

    public float MaxDuration = 3;
    float duration = 0;

    public float scaleMod = 2;

	// Update is called once per frame
	void Update ()
    {
        duration += Time.deltaTime;
        if(duration >= MaxDuration)
        {
            expand = !expand;
            duration = 0;
        }

	    if(animate)
        {
            if(expand)
            {
                transform.localScale += new Vector3(0, scaleMod, 0) * Time.deltaTime;
            }
            else
            {
                transform.localScale += new Vector3(0, -scaleMod, 0) * Time.deltaTime;
            }
            
        }
        else
        {
            transform.localScale = new Vector3(10, 10, 1);
        }
	}
}
