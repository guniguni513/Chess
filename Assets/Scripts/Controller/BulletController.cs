using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    float destroyTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    // Update is called once per frame
    void Update()
    {
        destroyTime += Time.deltaTime;
        Debug.Log(destroyTime);
        if(destroyTime >= 3)
        {
            destroyTime = 0;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("HIT");
        //Destroy(gameObject);
    }
}
