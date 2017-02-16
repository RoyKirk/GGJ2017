using UnityEngine;
using System.Collections;

public class CreateLevel : MonoBehaviour
{
    public GameObject[] SpawnPos;

    public GameObject[] Objects;

    void Start()
    {
        foreach (GameObject spawn in SpawnPos)
        {
            Instantiate(Objects[Random.Range(0, Objects.Length)], spawn.transform.position, Quaternion.identity);
        }
    }
}


