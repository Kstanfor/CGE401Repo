﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
		 * (Kaiser Stanford)
		 * (ScoreManager)
		 * (Prototype1)
		 * (Restart)
		 */

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public Text textbox;

    void Start() 
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // if game not over display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        // Win condition: 3 or more points
        if (score >= 3)
        {
            won = true;
            gameOver = true;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You Win!\nPress R to Try Again! ";
            }
            else 
            {
                textbox.text = "You Lose!\nPress R to Try Again! ";
            }
            if (Input.GetKeyDown(KeyCode.R)) 
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }

    }
}
