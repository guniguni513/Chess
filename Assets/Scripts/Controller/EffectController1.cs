using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController1 : MonoBehaviour
{
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {

        //Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(
            effect,
            transform.position,
            Quaternion.identity
        );
        Destroy(gameObject);
    }
}
