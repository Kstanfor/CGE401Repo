using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    public int score;
    public Text textbox;

    public GameObject loseText;
    public GameObject winText;

    private bool won;
    // Start is called before the first frame update
    void Start()
    {
        won = false;
        score = 0;
        textbox.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;

        if (transform.position.y < -5)
        {
            loseText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        else if (won) 
        {
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             }
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("End")) 
        {
            winText.SetActive(true);
            won = true;
        }
        else if (other.gameObject.CompareTag("Gem"))
        {
            score++;
        }
    }
}
