using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;



//attach to player
public class LoseOnFall : MonoBehaviour
{
    



    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1) 
        {
            ScoreManager.gameOver = true;
        }
    }
}
