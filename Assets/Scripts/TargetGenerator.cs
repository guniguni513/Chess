using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject target;
    public int targets = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < targets; i++)
        {
            float x = Random.Range(0.0f, 21.0f);
            float y = Random.Range(0.0f, 3.0f);
            Instantiate(
            target,
            new Vector3(x - 10, y, 10),
            Quaternion.identity
            );
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
