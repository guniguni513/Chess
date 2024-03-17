using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject Bullet;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(
                Bullet,
                pos,
                Quaternion.identity                
                );

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 dir = ray.direction;
            bullet.GetComponent<BulletController>().Shoot(dir.normalized*2000);
            
        }



    }

}
