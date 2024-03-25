using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.tag == "Bullet")
      {
        Destroy(collision.gameObject);
      }
    }
}
