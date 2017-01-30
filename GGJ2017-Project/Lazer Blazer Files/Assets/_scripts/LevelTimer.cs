using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelTimer : MonoBehaviour
{
    float timer;
    public Text myText;

	// Use this for initialization
	void Start ()
    {
        timer = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        myText.text = ((int)timer).ToString();
	}
}
