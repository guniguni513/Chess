using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletGenerator : MonoBehaviour
{
    public GameObject Bullet;
    Vector3 pos;
    AudioSource shotSound;
    public GameObject Human;
    public float bulletSpeed;

    void Start()
    {
        shotSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        CreateBullet();
    }

    void CreateBullet()
    {
        //bullet生成場所指定のため
        pos = Camera.main.transform.position;
        Vector3 cameraPos = Camera.main.transform.eulerAngles;
        Vector3 humanPos = transform.parent.eulerAngles;
        Transform parent = this.transform;
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(
                Bullet,
                pos,
                Quaternion.Euler(90 + cameraPos.x, humanPos.y, 0)
                );

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 dir = ray.direction;
            bullet.GetComponent<BulletController>().Shoot(dir.normalized * bulletSpeed);

            shotSound.Play();

        }
    }
}