using UnityEngine;
using System.Collections;

public class RapidFireScript : MonoBehaviour
{

    PlayerControllerNew playerController;
    int player = 0;

    public GameObject projectile;
    GameObject shot;

    public float MaxDuration;
    public float currentDuration = 0;

    public float bulletDelay;
    public float currentBulletDelay = 0;

    public float initialDelay;
    public float currentInitialDelay;

    public float CoolDown;
    public float currentCoolDown;

    public float Speed;

    bool startShooting;

	// Use this for initialization
	void Start ()
    {
        playerController = GetComponentInParent<PlayerControllerNew>();
        player = playerController.player;
        currentCoolDown = CoolDown;
        currentBulletDelay = bulletDelay;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(currentCoolDown <= CoolDown)
        {
            currentCoolDown += Time.deltaTime;
        }
        else//off CoolDown
        {
            if (Controller.state[player].Triggers.Left >= 0.3f)
            {
                //what happens when shooting
                currentDuration += Time.deltaTime;
                currentInitialDelay += Time.deltaTime;

                playerController.RapidFiring = true;

                if(currentDuration >= MaxDuration)
                {
                    //stop shooting
                    currentCoolDown = 0;
                    currentDuration = 0;
                    playerController.RapidFiring = false;
                    startShooting = false;
                }
                else if(currentInitialDelay >= initialDelay)
                {
                    startShooting = true;
                    currentBulletDelay += Time.deltaTime;
                    if(currentBulletDelay >= bulletDelay)
                    {
                        shot = Instantiate(projectile, transform.position, transform.rotation) as GameObject;
                        shot.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * Speed * Time.deltaTime);
                        Physics.IgnoreCollision(shot.GetComponent<Collider>(), GetComponent<Collider>());
                        shot.GetComponent<RapidProjectile>().playerCollider = GetComponent<Collider>();
                        currentBulletDelay = 0;
                    }
                }
            }
            else//released trigger
            {
                if(startShooting)
                {
                    currentCoolDown = 0;
                }
                currentDuration = 0;
                currentBulletDelay = 0;
                initialDelay = 0;
                playerController.RapidFiring = false;
                startShooting = false;
            }
        }
    }
}
