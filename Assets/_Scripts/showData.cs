using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showData : MonoBehaviour
{

    public Text playernameText;
    public Text currnetScoreText;
    public Text highScoreText;
    public Text SpeedText;


    void Awake()
    {
        playernameText.text = "Name: " + KeepData.PlayerName;
        currnetScoreText.text = "Last score: " + KeepData.Currentscore;
        highScoreText.text = "High score: " + KeepData.HighScore.ToString();
        KeepData.Currentscore = 0;
       
    }
    
}

