using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * (Kaiser Stanford)
		 * (ZoneScore)
		 * (Prototype1)
		 * (Increase by one with zones)
		 */
//attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }



}
