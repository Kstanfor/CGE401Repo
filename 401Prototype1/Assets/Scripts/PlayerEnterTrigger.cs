using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

/*
		 * (Kaiser Stanford)
		 * (Player enters Trigger)
		 * (Prototype1)
		 * (Detect)
		 */
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
