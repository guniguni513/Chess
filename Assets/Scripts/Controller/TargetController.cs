using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Instantiate(
            particle,
            this.transform.position,
            Quaternion.identity
        );
        Destroy(gameObject);
    }

    void OnCollisionStay(Collision other)
    {
        Debug.Log("Stay");
    }
}
