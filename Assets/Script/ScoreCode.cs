using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCode : MonoBehaviour {

    //宣告分數參數
    public static int Score;
    public static int highScore;

    //宣告文字UI
    public Text ShowScore;
    public Text HighScore;

    void Start ()
    {
        HighScore.text = PlayerPrefs.GetInt("HighSocre", 0).ToString();  
    }

    void Update() {

        //讓UI文字與分數同步
        ShowScore.text = Score.ToString();
        
        if (Score > PlayerPrefs.GetInt("HighScore", 0)) 
        {
            PlayerPrefs.SetInt("HighScore", Score);
            HighScore.text = Score.ToString();
        }
    }
}