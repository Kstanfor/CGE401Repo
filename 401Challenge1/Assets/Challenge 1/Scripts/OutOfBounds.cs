using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

//attach to player

public class OutOfBounds : MonoBehaviour
{
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51) 
        {
            textbox.text = "You Lose!";
        }

        if (transform.position.y > 80)
        {
            textbox.text = "You Lose!";
        }
    }
}
