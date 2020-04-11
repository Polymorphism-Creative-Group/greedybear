using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour
{
    public static int Score;
    public Text ScoreText;
    public Text HighScoreText;

    void Update()
    {
        ScoreText.text = Score.ToString();
     }
}