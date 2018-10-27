using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenager : MonoBehaviour {

    bool isPause=false;
    bool isNewGame = true;
    public Text pause;
    public Text newGame;
    public Text textPressN;
    public Text exit;
    public Text yes;
    public Text no;

    private void Update()
    {

        if(isNewGame)
        {
            Time.timeScale = 0f;
            pause.enabled = false;
            exit.enabled = false;
            no.enabled = false;
            yes.enabled = false;
            newGame.enabled = true;
            textPressN.enabled = true;

            if(Input.GetKeyDown(KeyCode.N))
            {
                Time.timeScale = 1f;
                textPressN.enabled = false;
                newGame.enabled = false;

                isNewGame = false;
            }

        }

        if(Input.GetKeyDown(KeyCode.Escape) && !isNewGame)
        {
            Time.timeScale = 0f;
            pause.enabled = false;
            newGame.enabled = false;
            textPressN.enabled = false;

            exit.enabled = true;
            no.enabled = true;
            yes.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.Y) && exit.enabled)
        {
            PointsMenager points = FindObjectOfType<PointsMenager>();
            points.HighScore();

            Application.Quit();
            Debug.Log("EXIT!");
        }

        else if (Input.GetKeyDown(KeyCode.N) && exit.enabled)
        {
            Time.timeScale = 1f;
            exit.enabled = false;
            no.enabled = false;
            yes.enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.P) && !isNewGame && !exit.enabled)
        {
            isPause = !isPause;

            if(isPause)
            {
                Time.timeScale = 0f;
                pause.enabled = true;
            }
            else
            {
                Time.timeScale = 1f;
                pause.enabled = false;
            }
        }
    }
}
