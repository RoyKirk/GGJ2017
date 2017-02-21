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

		if (m_handler != null) 
		{
			CheckInput ();
		}
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
		if (Input.GetAxis("TriggersL_1") > 0.5f) //harvest block
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
					m_handler.mostRecentOrder = currentblock;
				}
			}
			m_handler.myAudio.Play();
		}

		else if (Input.GetAxis("TriggersR_1") > 0.5f) //build on block
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
					m_handler.mostRecentOrder = currentblock;
				}
			}
			m_handler.myAudio.Play();
		}

		if (Input.GetButton("LS_1")) //destroy wall
		{
			RaycastHit hit;

			if (Physics.Raycast(transform.position, Vector3.down, out hit) && hit.transform.gameObject.tag == "Building")
			{
				BuildingBlock currentblock = hit.transform.gameObject.GetComponent<BuildingBlock>();
				if (currentblock.toBeDemolished == false) 
				{
					currentblock.toBeDemolished = true;
					AgentHandler.demolitionOrders.Add(currentblock);
				}
			}
			m_handler.myAudio.Play();
		}

		if (Input.GetButton("RS_1")) //cancel order
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(transform.position, Vector3.down, out hit) && hit.transform.gameObject.tag == "Ground")
			{
				GroundBlocks currentblock = hit.transform.gameObject.GetComponent<GroundBlocks>();
				if (currentblock.assignedTask == true) 
				{
					currentblock.CancelOrder ();
					currentblock.cancelAnimator.SetActive (true);
				} 

				else if (currentblock.isDigOrder) 
				{
					AgentHandler.digOrders.Remove(currentblock);
				} 

				else if (currentblock.isBuildOrder)
				{
					AgentHandler.buildOrders.Remove(currentblock);
				}
			}
			m_handler.myAudio.Play();
		}

		else if (Input.GetButtonDown("B_1") && m_handler.mostRecentOrder != null) //cancel most recent order
		{
			if (m_handler.mostRecentOrder.isBuildOrder == true) 
			{
				AgentHandler.buildOrders.Remove (m_handler.mostRecentOrder);	
			} 

			if (m_handler.mostRecentOrder.isDigOrder == true)
			{
				AgentHandler.digOrders.Remove (m_handler.mostRecentOrder);	
			}

			m_handler.mostRecentOrder.CancelOrder ();
			m_handler.mostRecentOrder.cancelAnimator.SetActive (true);
		}

		else if (Input.GetButtonDown("X_1") && (AgentHandler.buildOrders.Count > 0 || AgentHandler.digOrders.Count > 0)) //cancel furthest order
		{
			GroundBlocks orderToCancel = null;
			bool isDigOrder = false;
			if (AgentHandler.buildOrders.Count > 0) 
			{
				orderToCancel = AgentHandler.buildOrders[0];
			}

			else if (AgentHandler.digOrders.Count > 0) 
			{
				orderToCancel = AgentHandler.digOrders[0];
			}

			//at this point orderToCancel should be asssigned
			if (orderToCancel != null) 
			{
				foreach(GroundBlocks currentBlock in AgentHandler.buildOrders)
				{
					if (Vector3.Distance (m_handler.transform.position, currentBlock.transform.position) > Vector3.Distance (m_handler.transform.position, orderToCancel.transform.position)) 
					{
						orderToCancel = currentBlock;
						isDigOrder = false;
					}
				}

				foreach(GroundBlocks currentBlock in AgentHandler.digOrders)
				{
					if (Vector3.Distance (m_handler.transform.position, currentBlock.transform.position) > Vector3.Distance (m_handler.transform.position, orderToCancel.transform.position)) 
					{
						orderToCancel = currentBlock;
						isDigOrder = true;
					}
				}

				orderToCancel.CancelOrder ();
				orderToCancel.cancelAnimator.SetActive (true);
				if (isDigOrder == true) 
				{
					AgentHandler.digOrders.Remove (orderToCancel);	
				} 

				else 
				{
					AgentHandler.buildOrders.Remove (orderToCancel);	
				}
			}
		}
	}
}
