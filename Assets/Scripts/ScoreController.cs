using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Reflection.Emit;

public class ScoreController : MonoBehaviour
{
    TextMeshProUGUI tmPro;
    void Start()
    {
        tmPro = GetComponent<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello");
        tmPro.text = "Rigidbody"; 
    }

    void OnGUI()
    {
        GUI.Label(new Rect(50,50,100,100),"Hello");
    }
}
