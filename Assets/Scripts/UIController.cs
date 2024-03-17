using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject Player2;
    public GameObject Speed;
    private int Player_Speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       Player_Speed = (int)Player2.GetComponent<Rigidbody>().velocity.magnitude*1000/3600;
       Speed.GetComponent<TextMeshProUGUI>().text = Player_Speed + "km/h";
    }
    
    void OnGUI()
    {
        GUI.Label(new Rect(50,50,100,100),Player_Speed+"km/h");
    }
}
