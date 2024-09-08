using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * (Kaiser Stanford)
		 * (TriggerZoneOnEnter)
		 * (Challenge1)
		 * (score up by one)
		 */

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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
