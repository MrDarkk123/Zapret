using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    Vector3 position;
    void Start()
    {
        position = transform.position;
    }

    void Update()
    {
        position.x = player.transform.position.x;
        transform.position = position;
    }
}
