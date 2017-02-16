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

    public float VelocityClamp = 5;
    
    private Vector3 lookDirection;

    public float turnSpeed = 2;


    public GameObject FireBallPrefab;
    public GameObject shootPos;

    public float FireBallShootDelay = 1;
    float currentFireBallShootDelay = 0;

    GameObject projectile;

    public float ThrustExplosiveForce;
    public float PlayerThrustRadius;

    public GameObject ThrustAnim;

    private Vector3 oldVelocity;

    public bool THRUST_ABILITY = false;
    public bool BLAST_ABILITY = false;

    public float ThrustDelay = 5f;
    float currentThrustDelay = 0;
    public float ThrustSpeed = 2;
    public bool Thrusting = false;


    //public float ThrustCollisionForce;
    //public float ThrustRadius;

    // Use this for initialization
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            Destroy(gameObject);
        }

        if(Thrusting)
        {
            //PlayerThrustCollision();
            currentThrustDuration += Time.deltaTime;
            if(currentThrustDuration >= ThrustDuration)
            {
                speed = speed / ThrustSpeed;
                VelocityClamp = VelocityClamp / ThrustSpeed;
                Thrusting = false;
                ThrustAnim.SetActive(false);
                currentThrustDuration = 0;
            }
            ThumbstickMove();
            Rotate();
        }
        else
        {
            ThumbstickMove();
            Rotate();
            ShootFireBall();

            if(THRUST_ABILITY)
            {
                Thrust();
            }
            if(BLAST_ABILITY)
            {
                Blast();
            }
        }
    }
    

    void ThumbstickMove()
    {
        //move left or right
        if (Controller.state[player].ThumbSticks.Left.X > thumbXDeadZone)
        {
            if (Rb.velocity.x > VelocityClamp)
            {
                //Rb.velocity = new Vector3(VelocityClamp, Rb.velocity.y, Rb.velocity.z);
            }
            else
            {
                Rb.AddForce(Vector3.right * speed * Time.deltaTime);
            }
        }
        else if(Controller.state[player].ThumbSticks.Left.X < -thumbXDeadZone)
        {
            if (Rb.velocity.x < -VelocityClamp)
            {
                //Rb.velocity = new Vector3(-VelocityClamp, Rb.velocity.y, Rb.velocity.z);
            }
            else
            {
                Rb.AddForce(Vector3.left * speed * Time.deltaTime);
            }
            
        }
        
        //move up or down
        if (Controller.state[player].ThumbSticks.Left.Y > thumbYDeadZone)
        {
            if (Rb.velocity.z > VelocityClamp)
            {
                //Rb.velocity = new Vector3(Rb.velocity.x, Rb.velocity.y, VelocityClamp);
            }
            else
            {
                Rb.AddForce(Vector3.forward * speed * Time.deltaTime);
            }
        }
        else if(Controller.state[player].ThumbSticks.Left.Y < -thumbYDeadZone)
        {
            if (Rb.velocity.z < -VelocityClamp)
            {
                //Rb.velocity = new Vector3(Rb.velocity.x, Rb.velocity.y, -VelocityClamp);
            }
            else
            {
                Rb.AddForce(Vector3.back * speed * Time.deltaTime);
            }
        }
    }

    
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

    
    
    void FixedUpdate()
    {
        oldVelocity = Rb.velocity;
    }

    void OnCollisionEnter(Collision c)
    {
        if(Thrusting)
        {
            if (c.gameObject.tag == "Player" || c.gameObject.tag == "Object")
            {
                Debug.Log("hit PLayer");
                c.rigidbody.AddExplosionForce(ThrustExplosiveForce, transform.position, PlayerThrustRadius);
                c.rigidbody.AddForce(Rb.velocity);
                speed = speed / ThrustSpeed;
                VelocityClamp = VelocityClamp / ThrustSpeed;
                Thrusting = false;
                Rb.velocity = Vector3.zero;
                currentThrustDuration = 0;
                ThrustAnim.SetActive(false);
            }
            else if (c.gameObject.tag == "Reflect")
            {

                // get the point of contact
                ContactPoint contact = c.contacts[0];

                // reflect our old velocity off the contact point's normal vector
                Vector3 reflectedVelocity = Vector3.Reflect(oldVelocity, contact.normal);

                // assign the reflected velocity back to the rigidbody
                Rb.velocity = reflectedVelocity;
                // rotate the object by the same ammount we changed its velocity
                Quaternion rotation = Quaternion.FromToRotation(oldVelocity, reflectedVelocity);
                transform.rotation = rotation * transform.rotation;
            }
        }
    }


    void ShootFireBall()
    {
        currentFireBallShootDelay += Time.deltaTime;
        if(currentFireBallShootDelay >= FireBallShootDelay)
        {
            if (Controller.state[player].Triggers.Right >= thumbXDeadZone)
            {
                projectile = Instantiate(FireBallPrefab, shootPos.transform.position, transform.rotation) as GameObject;
                Physics.IgnoreCollision(projectile.GetComponent<Collider>(), GetComponent<Collider>());
                projectile.GetComponent<FireBallScript>().playerCollider = GetComponent<Collider>();
                currentFireBallShootDelay = 0;
            }
        }
       
    }


    

    void Thrust()
    {
        currentThrustDelay += Time.deltaTime;
        if(currentThrustDelay >= ThrustDelay)
        {
            //if (Controller.state[player].Triggers.Left >= thumbXDeadZone)
            if(Controller.state[player].Buttons.B == XInputDotNetPure.ButtonState.Pressed)
            {
                speed = speed * ThrustSpeed;
                VelocityClamp = VelocityClamp * ThrustSpeed;
                //Rb.AddRelativeForce(Vector3.forward * ThrustForce * Time.deltaTime);
                //transform.Translate(transform.forward * ThrustForce * Time.deltaTime);
                //Rb.velocity = Vector3.zero;
                Thrusting = true;
                currentThrustDelay = 0;
                ThrustAnim.SetActive(true);
            }
        }
    }

    public float currentBlastShootDelay = 0;
    public float BlastShootDelay = 0.75f;

    GameObject BlastProjectile;
    public GameObject BlastPrefab;

    void Blast()
    {
        currentBlastShootDelay += Time.deltaTime;
        if (currentBlastShootDelay >= BlastShootDelay)
        {
            if (Controller.state[player].Triggers.Left >= thumbXDeadZone)
            {
                BlastProjectile = Instantiate(BlastPrefab, shootPos.transform.position, transform.rotation) as GameObject;
                Physics.IgnoreCollision(BlastProjectile.GetComponent<Collider>(), GetComponent<Collider>());
                currentBlastShootDelay = 0;
            }
        }
    }

    
}


//void PlayerThrustCollision()
//{


//Vector3 fwd = transform.TransformDirection(Vector3.forward);
//
//RaycastHit hit;
//
//Ray rayLeft = new Ray(new Vector3(transform.position.x + 0.5f, transform.position.y,transform.position.z), fwd);
//
//if (Physics.Raycast(rayLeft, out hit, 0.7f))
//{
//    if (hit.transform.tag == "Player")
//    {
//        //reset thrust
//        Thrusting = false;
//        currentThrustDuration = 0;
//        Rb.velocity = Vector3.zero;
//        //apply force to other player
//        //hit.rigidbody.AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
//        hit.transform.GetComponent<Rigidbody>().AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
//    }
//}
//
//Ray rayRight = new Ray(new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z), fwd);
//
//if (Physics.Raycast(rayRight, out hit, 0.7f))
//{
//    if (hit.transform.tag == "Player")
//    {
//        //reset thrust
//        Thrusting = false;
//        currentThrustDuration = 0;
//        Rb.velocity = Vector3.zero;
//        //apply force to other player
//        //hit.rigidbody.AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
//        hit.transform.GetComponent<Rigidbody>().AddExplosionForce(ThrustCollisionForce, transform.position, ThrustRadius);
//    }
//}
//}

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