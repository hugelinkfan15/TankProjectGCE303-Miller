using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    // Start is called before the first frame update

    public TMP_Text textbox;
    public int scoreToWin;
    private float timer;
    private float keypress;
    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }
        if (score >= scoreToWin)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nHold R to Try Again!";
            }
            else
            {
                textbox.text = "You lose!\nHold R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                //timer = Time.time;
                //while (!Input.GetKeyUp(KeyCode.R))
                //{
                   // keypress = Time.time - timer;
                    //if(keypress>3)
                    //{
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    //}
                //}
            }
        }
    }
}
