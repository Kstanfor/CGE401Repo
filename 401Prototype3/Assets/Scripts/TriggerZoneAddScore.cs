using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* (Kaiser Stanford)
* (prototype 3)
* (adds score to jumps)
*/

public class TriggerZoneAddScore : MonoBehaviour
{
    private UIManager uIManager;

    private bool triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.FindObjectOfType<UIManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered) 
        {
            triggered = true;
            UIManager.score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
