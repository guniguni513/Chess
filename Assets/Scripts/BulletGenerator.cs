using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletGenerator : MonoBehaviour
{
    public GameObject Bullet;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //bullet生成場所指定のため
        pos = Camera.main.transform.position;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(
                Bullet,
                pos,
                Quaternion.Euler(90,0,0)                
                );

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 dir = ray.direction;
            bullet.GetComponent<BulletController>().Shoot(dir.normalized*2000);
            
        }
    }
}
