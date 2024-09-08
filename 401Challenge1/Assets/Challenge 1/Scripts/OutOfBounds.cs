using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;


//attach to player

public class OutOfBounds : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51) 
        {
            ScoreManager.gameOver = true;
        }

        if (transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
