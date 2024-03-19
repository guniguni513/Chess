using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject target;
    float timer;
    public float span = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    IEnumerator abon()
    {
        //弾の連射制限に使える
        yield return new WaitForSeconds(1f);
    }

    void CreateTarget()
    {
        float x = Random.Range(0.0f, 21.0f);
        float y = Random.Range(0.0f, 3.0f);
        Instantiate(
        target,
        new Vector3(x - 10, y, 10),
        Quaternion.identity
        );
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if (timer >= span)
        {
            timer = 0;
            CreateTarget();
        }

    }
}
