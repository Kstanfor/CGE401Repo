﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
* (Kaiser Stanford)
* (prototype 3)
* (incraments displayed score)
*/

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public PlayerControllerX playerControllerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {

        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }
        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        }
        scoreText.text = "Score: 0";

    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to Try Again!";
        }

        if (score >= 10)
        {
            playerControllerScript.gameOver = true;
            won = true;



            scoreText.text = "You Win!" + "\n" + "Press R to Try Again!";
        }

        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}