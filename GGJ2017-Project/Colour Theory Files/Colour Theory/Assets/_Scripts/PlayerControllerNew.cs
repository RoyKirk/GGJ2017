using UnityEngine;
using System.Collections;

public class PlayerControllerNew : MonoBehaviour
{

    public int player = 0;

    public float speed = 0.5f;

    public float thumbXDeadZone = 0.2f;
    public float thumbYDeadZone = 0.2f;
    

    //Collider collider;
    Rigidbody Rb;



    //thrusting vars
    public float ThrustDuration;
    float currentThrustDuration;

    // Use this for initialization
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(Thrusting)
        {
            PlayerThrustCollision();
            currentThrustDuration += Time.deltaTime;
            if(currentThrustDuration >= ThrustDuration)
            {
                //Rb.velocity = Vector3.zero;
                Thrusting = false;
                currentThrustDuration = 0;
            }
            Rb.AddRelativeForce(Vector3.forward * ThrustForce * Time.deltaTime);
        }
        else
        {
            ThumbstickMove();
            Rotate();
            ShootFireBall();
            Thrust();
        }
    }
    

    void ThumbstickMove()
    {
        //move left or right
        if (Controller.state[player].ThumbSticks.Left.X > thumbXDeadZone)
        {
            Rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        else if(Controller.state[player].ThumbSticks.Left.X < -thumbXDeadZone)
        {
            Rb.AddForce(Vector3.left * speed * Time.deltaTime);
        }
        
        //move up or down
        if (Controller.state[player].ThumbSticks.Left.Y > thumbYDeadZone)
        {
            Rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
        else if(Controller.state[player].ThumbSticks.Left.Y < -thumbYDeadZone)
        {
            Rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }
        
        //clamp velocity
        if(Rb.velocity.x > VelocityClamp)
        {
            Rb.velocity = new Vector3(VelocityClamp, Rb.velocity.y,Rb.velocity.z);
        }
        else if (Rb.velocity.x < -VelocityClamp)
        {
            Rb.velocity = new Vector3(-VelocityClamp, Rb.velocity.y, Rb.velocity.z);
        }
        if (Rb.velocity.z > VelocityClamp)
        {
            Rb.velocity = new Vector3(Rb.velocity.x, Rb.velocity.y, VelocityClamp);
        }
        else if (Rb.velocity.z < -VelocityClamp)
        {
            Rb.velocity = new Vector3(Rb.velocity.x, Rb.velocity.y, -VelocityClamp);
        }
    }

    public float VelocityClamp = 5;

    
    private Vector3 lookDirection;

    public float turnSpeed = 2;
    //raycast to move in a direction
    void Rotate()
    {
        if (Mathf.Abs(Controller.state[player].ThumbSticks.Right.X) > thumbXDeadZone || Mathf.Abs(Controller.state[player].ThumbSticks.Right.Y) > thumbXDeadZone)
        {
            lookDirection = new Vector3( Controller.state[player].ThumbSticks.Right.X, 0, Controller.state[player].ThumbSticks.Right.Y);
            lookDirection = Quaternion.AngleAxis(0, Vector3.up) * lookDirection;
            //transform.right = lookDirection;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDirection), Time.deltaTime * turnSpeed);
        }
    }

    
    public GameObject FireBallPrefab;
    public GameObject shootPos;

    public float FireBallShootDelay = 1;
    float currentFireBallShootDelay = 0;

    void ShootFireBall()
    {
        currentFireBallShootDelay += Time.deltaTime;
        if(currentFireBallShootDelay >= FireBallShootDelay)
        {
            if (Controller.state[player].Triggers.Right >= thumbXDeadZone)
            {
                Instantiate(FireBallPrefab, shootPos.transform.position, transform.rotation);
                currentFireBallShootDelay = 0;
            }
        }
       
    }


    public float ThrustDelay = 5f;
    float currentThrustDelay = 0;
    public float ThrustForce = 100;
    public bool Thrusting = false;

    void Thrust()
    {
        currentThrustDelay += Time.deltaTime;
        if(currentThrustDelay >= ThrustDelay)
        {
            if (Controller.state[player].Triggers.Left >= thumbXDeadZone)
            {
                //Rb.AddRelativeForce(Vector3.forward * ThrustForce * Time.deltaTime);
                //transform.Translate(transform.forward * ThrustForce * Time.deltaTime);
                Rb.velocity = Vector3.zero;
                Thrusting = true;
                currentThrustDelay = 0;
            }
        }
    }

    public float ThrustCollisionForce;
    public float ThrustRadius;

    void PlayerThrustCollision()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        RaycastHit hit;

        Ray rayLeft = new Ray(new Vector3(transform.position.x + 0.5f, transform.position.y,transform.position.z), fwd);

        if (Physics.Raycast(rayLeft, out hit, 0.7f))
        {
            if (hit.transform.tag == "Player")
            {
                //reset thrust
                Thrusting = false;
                currentThrustDuration = 0;
                Rb.velocity = Vector3.zero;
                //apply force to other player
                //hit.rigidbody.AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
                hit.transform.GetComponent<Rigidbody>().AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
            }
        }

        Ray rayRight = new Ray(new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z), fwd);

        if (Physics.Raycast(rayRight, out hit, 0.7f))
        {
            if (hit.transform.tag == "Player")
            {
                //reset thrust
                Thrusting = false;
                currentThrustDuration = 0;
                Rb.velocity = Vector3.zero;
                //apply force to other player
                //hit.rigidbody.AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
                hit.transform.GetComponent<Rigidbody>().AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
            }
        }
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

//void DpadMove()
//{
//   ////left to right
//   //if (Controller.state[player].DPad.Right == XInputDotNetPure.ButtonState.Pressed)
//   //{
//   //    gameObject.transform.position += Vector3.right * speed * Time.deltaTime;
//   //}
//   //else if (Controller.state[player].DPad.Left == XInputDotNetPure.ButtonState.Pressed)
//   //{
//   //    gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
//   //}
//   //
//   ////up and down
//   //else if (Controller.state[player].DPad.Up == XInputDotNetPure.ButtonState.Pressed)
//   //{
//   //    gameObject.transform.position += Vector3.forward * speed * Time.deltaTime;
//   //}
//   //else if (Controller.state[player].DPad.Down == XInputDotNetPure.ButtonState.Pressed)
//   //{
//   //    Debug.Log("player wants to move down");
//   //    gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
//   //}
//}