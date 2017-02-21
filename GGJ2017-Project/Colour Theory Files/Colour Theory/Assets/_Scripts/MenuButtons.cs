using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour
{
    public GameObject[] Letters;
    public GameObject[] Players;

    public GameObject[] Title;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        for(int i = 0; i < Players.Length; i++)
        {
            if (Players[i] != null)
            {
                Letters[i].GetComponent<Renderer>().material.color = Players[i].GetComponent<Renderer>().material.color;
                if(i < 2)
                {
                    Title[i].GetComponent<Renderer>().material.color = Players[i].GetComponent<Renderer>().material.color;
                }
                Letters[i].GetComponent<LetterFeedback>().animate = true;
            }
            else
            {
                Letters[i].GetComponent<Renderer>().material.color = Color.white;
                if (i < 2)
                {
                    Title[i].GetComponent<Renderer>().material.color = Color.white;
                }
                Letters[i].GetComponent<LetterFeedback>().animate = false;
            }
        }

        for(int i = Players.Length - 1; i >= 0; i--)
        {
            if (Players[i] == null)
            {
                iterator = i;
            }
        }
        if(iterator == 4)
        {
            //Debug.Log("all players ready");
            currentStartTimer += Time.deltaTime;
            if(currentStartTimer >= startTimer)
            {
                Application.LoadLevel(1);
            }
        }
        else
        {
            currentStartTimer = 0;
        }
	}

    float startTimer = 3;
    float currentStartTimer = 0;

    int iterator = 0;

    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Player")
        {
            Debug.Log(iterator);
            Players[iterator] = c.gameObject;
            iterator++;
        }
    }

    void OnTriggerExit(Collider c)
    {
        for(int i = 0; i < Players.Length; i++)
        {
            if(Players[i] != null)
            {
                if (Players[i].name == c.name)
                {
                    Players[i] = null;
                    sortPlayers();
                }
            }
        }
    }

    void sortPlayers()
    {
        for(int i = Players.Length - 1; i >= 1; i--)
        {
            if(Players[i] != null && Players[i - 1] == null)
            {
                Players[i - 1] = Players[i];
                Players[i] = null;
                sortPlayers();
            }
        }
    }
}
