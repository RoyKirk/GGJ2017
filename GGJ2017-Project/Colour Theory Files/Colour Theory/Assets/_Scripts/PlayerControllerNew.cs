using UnityEngine;
using System.Collections;

public class PlayerControllerNew : MonoBehaviour
{

    public int player = 0;

    public float speed = 0.5f;

    public float thumbXDeadZone = 0.2f;
    public float thumbYDeadZone = 0.2f;

    
    public float ROTATE_MAX_DELAY_TIMER = 1f;
    public float currentRotateDelay;

    //Collider collider;
    Rigidbody Rb;

    // Use this for initialization
    void Start()
    {
        //currentRotateDelay = 0;
        //collider = GetComponent<Collider>();
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        currentRotateDelay += Time.deltaTime;
        
        //ThumbstickMove();
        DpadMove();

        if (currentRotateDelay >= ROTATE_MAX_DELAY_TIMER)
        {
            Rotate();
        }
    }

    void FixedUpdate()
    {
        ThumbstickMove();
    }

    void ThumbstickMove()
    {
        //move left or right
        if (Controller.state[player].ThumbSticks.Left.X > thumbXDeadZone)
        {
            Rb.AddRelativeForce(Vector3.right * speed * Time.deltaTime);
        }
        else if(Controller.state[player].ThumbSticks.Left.X < -thumbXDeadZone)
        {
            Rb.AddRelativeForce(Vector3.left * speed * Time.deltaTime);
        }
        
        //move up or down
        if (Controller.state[player].ThumbSticks.Left.Y > thumbYDeadZone)
        {
            Rb.AddRelativeForce(Vector3.forward * speed * Time.deltaTime);
        }
        else if(Controller.state[player].ThumbSticks.Left.Y < -thumbYDeadZone)
        {
            Rb.AddRelativeForce(Vector3.back * speed * Time.deltaTime);
        }

        if(Rb.velocity.magnitude )
        //Rb.velocity += new Vector3(Controller.state[player].ThumbSticks.Left.X, 0, Controller.state[player].ThumbSticks.Left.Y) * speed * Time.deltaTime;
    }

    void DpadMove()
    {
        //left to right
        if (Controller.state[player].DPad.Right == XInputDotNetPure.ButtonState.Pressed)
        {
            gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Controller.state[player].DPad.Left == XInputDotNetPure.ButtonState.Pressed)
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        }

        //up and down
        else if (Controller.state[player].DPad.Up == XInputDotNetPure.ButtonState.Pressed)
        {
            gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        else if (Controller.state[player].DPad.Down == XInputDotNetPure.ButtonState.Pressed)
        {
            Debug.Log("player wants to move down");
            gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }

    //raycast to move in a direction
    void Rotate()
    {
        if (Controller.state[player].Triggers.Left > 0.3f)
        {
            if (Controller.state[player].Triggers.Left > Controller.state[player].Triggers.Right)
            {
                gameObject.transform.Rotate(0, -90, 0);
                currentRotateDelay = 0;
            }
        }
        if (Controller.state[player].Triggers.Right > 0.3f)
        {
            if (Controller.state[player].Triggers.Right > Controller.state[player].Triggers.Left)
            {
                gameObject.transform.Rotate(0, 90, 0);
                currentRotateDelay = 0;
            }
        }
        if (Controller.state[player].Triggers.Right > 0.9f && Controller.state[player].Triggers.Left > 0.9f)
        {
            gameObject.transform.Rotate(0, 180, 0);
            currentRotateDelay = 0;
        }
    }

    //check to see if there is a player where you are trying to move
    //void checkUnderneath()
    //{
    //    Ray ray = new Ray(transform.position, -transform.up);
    //    Debug.DrawRay(transform.position, -transform.up);
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray, out hit, 10))
    //    {
    //        transform.position = hit.collider.gameObject.transform.position;
    //        transform.position += Vector3.up;
    //    }
    //}
}
