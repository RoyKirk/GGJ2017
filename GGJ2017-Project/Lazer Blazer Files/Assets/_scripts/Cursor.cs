using UnityEngine;
using System.Collections;

public class Cursor : MonoBehaviour 
{
	Vector3 velocity;
	public float cursorSpeed;
	public AgentHandler m_handler;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Move ();
		CheckInput ();
	}

	void Move()
	{
		velocity = Vector3.zero;
		velocity.x = (Input.GetAxis("R_XAxis_1"));
		velocity.z = (Input.GetAxis("R_YAxis_1"));
		velocity = velocity.normalized * cursorSpeed;
		transform.position += velocity * Time.deltaTime;
	}

	void CheckInput()
	{
		if (Input.GetAxis("TriggersL_1") > 0.5f)
		{
			RaycastHit hit;

			if (Physics.Raycast (transform.position, Vector3.down, out hit) && hit.transform.gameObject.tag == "Ground")
			{
				GroundBlocks currentblock = hit.transform.gameObject.GetComponent<GroundBlocks>();
				if (currentblock.assignedTask == false && currentblock.Depleted == false)
				{
					AgentHandler.digOrders.Add(currentblock);
					currentblock.assignedTask = true;
					currentblock.gatherAnimator.SetActive(true);
				}
			}
			m_handler.myAudio.Play();
		}

		else if (Input.GetAxis("TriggersR_1") > 0.5f)
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, Vector3.down, out hit) && hit.transform.gameObject.tag == "Ground")
			{
				GroundBlocks currentblock = hit.transform.gameObject.GetComponent<GroundBlocks>();
				if (currentblock.assignedTask == false && currentblock.canBuildOn == true)
				{
					AgentHandler.buildOrders.Add(currentblock);
					currentblock.assignedTask = true;
					currentblock.buildAnimator.SetActive(true);
				}
			}
			m_handler.myAudio.Play();
		}
	}
}
