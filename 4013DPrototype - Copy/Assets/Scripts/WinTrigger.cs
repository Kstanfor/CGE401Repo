using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    
    public GameObject youWin;

    private bool won;

    // Start is called before the first frame update
    void Start()
    {
        won = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (won)
        {
           if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("WinTrigger")) 
        {
            youWin.SetActive(true);
            won = true;
        }
    }
}
