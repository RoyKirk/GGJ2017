using UnityEngine;
using System.Collections;

public class LaserController : MonoBehaviour
{
    public float speed = 1;
    public bool ORANGE = true;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.localPosition += Vector3.left * speed * Time.deltaTime;
        if(ORANGE)
        {
            RayCastCheckOrange();
        }
        else
        {
            RayCastCheckBlue();
        }


    }

    void RayCastCheckOrange()
    {
        Ray ray = new Ray(transform.position, -transform.right);
        Debug.DrawRay(transform.position, -transform.right);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 0.2f))
        {
            Debug.Log("hit " + hit.transform.name);
            if(hit.transform.tag == "OrangeShield")
            {
                DestroyObject(gameObject);
            }
            else if(hit.transform.tag == "BlueShield")
            {
                DestroyObject(hit.transform.gameObject);
                DestroyObject(gameObject);
            }
            else if(hit.transform.tag == "Player")
            {
                DestroyObject(hit.transform.gameObject);
            }
        }
    }

    void RayCastCheckBlue()
    {
        Ray ray = new Ray(transform.position, -transform.right);
        Debug.DrawRay(transform.position, -transform.right);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 0.2f))
        {
            Debug.Log("hit " + hit.transform.name);
            if (hit.transform.tag == "BlueShield")
            {
                DestroyObject(gameObject);
            }
            else if (hit.transform.tag == "OrangeShield")
            {
                DestroyObject(hit.transform.gameObject);
                DestroyObject(gameObject);
            }
            else if (hit.transform.tag == "Player")
            {
                DestroyObject(hit.transform.gameObject);
            }
        }
    }
}
