using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;


public class PlayerEnterTrigger : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
}
