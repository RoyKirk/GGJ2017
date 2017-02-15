using UnityEngine;
using System.Collections;

public class ReflectScript : MonoBehaviour
{
    
    PlayerControllerNew playerController;
    int player = 0;

    public BoxCollider collider;

    public float ReflectDelay = 1;
    public float currentReflectDelay = 0;
    public float reflectDuration = 0.3f;

    public GameObject reflectAnim;

    // Use this for initialization
    void Start()
    {
        playerController = GetComponentInParent<PlayerControllerNew>();
        player = playerController.player;
        collider = GetComponent<BoxCollider>();
        Physics.IgnoreCollision(GetComponentInParent<Collider>(), GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        currentReflectDelay += Time.deltaTime;
        if (currentReflectDelay >= ReflectDelay)
        {
            if (Controller.state[player].Buttons.X == XInputDotNetPure.ButtonState.Pressed)
            {
                collider.enabled = true;
                currentReflectDelay = 0;
                reflectAnim.SetActive(true);
                //still need to reset this so it turns off, maybe use a bool to control duration, eg. see thrust
            }
        }

        if (currentReflectDelay >= reflectDuration)
        {
            reflectAnim.SetActive(false);
            collider.enabled = false;
        }
    }
}

