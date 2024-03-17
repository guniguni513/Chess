using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player2;
    public Vector3 offset;

    void Start()
    {
        offset = transform.position - Player2.transform.position;
    }

    void Update()
    {
        transform.position = Player2.transform.position + offset;
    }
}
