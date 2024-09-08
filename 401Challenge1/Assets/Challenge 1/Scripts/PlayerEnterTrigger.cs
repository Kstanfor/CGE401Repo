using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Attach to player
public class PlayerEnterTrigger : MonoBehaviour
{
    public Text textbox;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            textbox.text = "You Win!";
        }
    }

}
