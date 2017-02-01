using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public int player = 0;

    public float speed = 0.5f;

    public float thumbXDeadZone = 0.2f;
    public float thumbYDeadZone = 0.2f;


    public float MOVE_MAX_DELAY_TIMER = 0.1f;
    public float currentMoveDelay;

    public float ROTATE_MAX_DELAY_TIMER = 1f;
    public float currentRotateDelay;

    Collider collider;

    // Use this for initialization
    void Start ()
    {
        currentMoveDelay = 0;
        currentRotateDelay = 0;
        collider = GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        currentMoveDelay += Time.deltaTime;
        currentRotateDelay += Time.deltaTime;


        if(currentMoveDelay >= MOVE_MAX_DELAY_TIMER)
        {
            //checkUnderneath();
            ThumbstickMove();
            DpadMove();
            //checkUnderneath();
        }

        if(currentRotateDelay >= ROTATE_MAX_DELAY_TIMER)
        {
            Rotate();
        }
    }

    void ThumbstickMove()
    {
        if(Mathf.Abs(Controller.state[player].ThumbSticks.Left.X) > thumbXDeadZone || Mathf.Abs(Controller.state[player].ThumbSticks.Left.Y) > thumbXDeadZone)
        {
            if (Mathf.Abs(Controller.state[player].ThumbSticks.Left.X) > Mathf.Abs(Controller.state[player].ThumbSticks.Left.Y))
            {
                //move left or right
                if (Controller.state[player].ThumbSticks.Left.X > thumbXDeadZone)
                {
                    if(transform.position.x < 8.4f)
                    {
                        gameObject.transform.position += Vector3.right * speed * Time.deltaTime;// * Time.deltaTime;
                        currentMoveDelay = 0;
                    }
                }
                else
                {
                    if (transform.position.x > 0)
                    {
                        gameObject.transform.position += Vector3.left * speed * Time.deltaTime;// * Time.deltaTime;
                        currentMoveDelay = 0;
                    }
                }
            }
            else
            {
                //move up or down
                if (Controller.state[player].ThumbSticks.Left.Y > thumbYDeadZone)
                {
                    if (transform.position.z < 8.4f)
                    {
                        gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;// * Time.deltaTime;
                        currentMoveDelay = 0;
                    }
                }
                else
                {
                    if (transform.position.z > 0)
                    {
                        gameObject.transform.position += Vector3.back * speed * Time.deltaTime;// * Time.deltaTime;
                        currentMoveDelay = 0;
                    }
                }
            }
        }

    }

    void DpadMove()
    {
        //left to right
        if (Controller.state[player].DPad.Right == XInputDotNetPure.ButtonState.Pressed)
        {
            gameObject.transform.position += Vector3.right * speed;// * Time.deltaTime;
            currentMoveDelay = 0;
        }
        else if (Controller.state[player].DPad.Left == XInputDotNetPure.ButtonState.Pressed)
        {
            gameObject.transform.position += Vector3.left * speed;// * Time.deltaTime;
            currentMoveDelay = 0;
        }

        //up and down
        else if (Controller.state[player].DPad.Up == XInputDotNetPure.ButtonState.Pressed)
        {
            gameObject.transform.position += Vector3.forward * speed;// * Time.deltaTime;
            currentMoveDelay = 0;
        }
        else if (Controller.state[player].DPad.Down == XInputDotNetPure.ButtonState.Pressed)
        {
            Debug.Log("player wants to move down");
            gameObject.transform.position += Vector3.back * speed;// * Time.deltaTime;
        }
    }

    //raycast to move in a direction
    void Rotate()
    {
        if(Controller.state[player].Triggers.Left > 0.3f )
        {
            if(Controller.state[player].Triggers.Left > Controller.state[player].Triggers.Right)
            {
                gameObject.transform.Rotate(0, -90, 0);
                currentRotateDelay = 0;
            }
        }
        if (Controller.state[player].Triggers.Right > 0.3f)
        {
            if(Controller.state[player].Triggers.Right > Controller.state[player].Triggers.Left)
            {
                gameObject.transform.Rotate(0, 90, 0);
                currentRotateDelay = 0;
            }
        }
        if(Controller.state[player].Triggers.Right > 0.9f && Controller.state[player].Triggers.Left > 0.9f)
        {
            gameObject.transform.Rotate(0, 180, 0);
            currentRotateDelay = 0;
        }
    }

    //check to see if there is a player where you are trying to move
    void checkUnderneath()
    {
        Ray ray = new Ray(transform.position, -transform.up);
        Debug.DrawRay(transform.position, -transform.up);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 10))
        {
            transform.position = hit.collider.gameObject.transform.position;
            transform.position += Vector3.up;
        }
    }
}
