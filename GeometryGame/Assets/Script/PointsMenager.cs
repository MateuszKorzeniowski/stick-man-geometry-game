using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsMenager : MonoBehaviour {
    public Text pointsText;
    public Text highScoreText;
    int points;
    int highScore=0;

    private void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = "High Score: " + highScore.ToString();

        points = PlayerPrefs.GetInt("Points");
        PrintPoints();
    }


    public void PrintPoints()
    {
        pointsText.text = points.ToString();
    }

    public void AddPoint()
    {
        points++;
    }

    public void HighScore()
    {
        if(points>highScore)
        {
            PlayerPrefs.SetInt("HighScore", points);
        }
    }
}
