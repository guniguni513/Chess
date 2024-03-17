using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    Rigidbody rb;
    Vector3 position;
    public bool Translate;
    public bool Rotate;
    public bool AddForce;
    public bool AddTorque;
    public bool Velocity;
    public float power = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        position.x = Input.GetAxis("Horizontal");
        position.z = Input.GetAxis("Vertical");

        position.x *= power;
        position.z *= power;

        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 0, 0);
        }

        if (rb.velocity.magnitude <= 216)
        {
            if (Translate)
            {
                transform.Translate(position.x, 0, position.z);
            }

            if (Rotate)
            {
                transform.Rotate(position.x, 0, position.z);
            }

            if (AddForce)
            {
                rb.AddForce(position.x, 0, position.z);
            }

            if (AddTorque)
            {
                position.x = Input.GetAxis("Vertical");
                position.z = Input.GetAxis("Horizontal");
                position.x *= power;
                position.z *= power;
                rb.AddTorque(position.x, 0, -position.z);
            }

            if (Velocity)
            {
                rb.velocity = new Vector3(position.x, 0, position.z);
            }
        }
    }
}