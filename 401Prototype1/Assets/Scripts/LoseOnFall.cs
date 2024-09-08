using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using UnityEngine;

/*
		 * (Kaiser Stanford)
		 * (lose on fall)
		 * (Prototype1)
		 * (what causes loss)
		 */

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
