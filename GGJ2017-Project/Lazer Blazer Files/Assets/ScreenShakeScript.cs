using UnityEngine;
using System.Collections;

public class ScreenShakeScript : MonoBehaviour {

    float shake = 0.0f;
    public float shakeAmount = 0.1f;
    public float shakeDuration = 0.3f;
    Camera camera;
    Vector3 initpos;
    public GameObject PauseScreen;
    public GameObject DefeatScreen;
    // Use this for initialization
    void Start () {
        camera = gameObject.GetComponent<Camera>();
        initpos = camera.transform.localPosition;
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKey("escape"))
        {
            PauseScreen.SetActive(true);
        }
        if (shake > 0)
        {
            camera.transform.localPosition = initpos + Random.insideUnitSphere * shakeAmount;
            shake -= Time.deltaTime;
        }
        else
        {
            camera.transform.localPosition = initpos;
        }
    }

    public void Shake()
    {
        shake = shakeDuration;
    }
}
