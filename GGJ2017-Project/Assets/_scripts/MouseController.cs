using UnityEngine;
using System.Collections;

public class MouseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetMouseButtonDown (0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                hit.transform.GetComponent<GroundBlocks>().harvested = true;
                //Debug.Log("you selected the " + hit.transform.name);
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100f))
            {
                hit.transform.GetComponent<GroundBlocks>().CreateBuilding();
                //Debug.Log("you selected the " + hit.transform.name);
            }
        }

    }
}
