using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveShowData : MonoBehaviour
{
    public Text highScoreText;
    public Text SpeedText;
    public Text playernameText;

    // Update is called once per frame
    void Update()
    {
        playernameText.text = "Name: " + KeepData.PlayerName;
        highScoreText.text = "High score: " + KeepData.HighScore;
        SpeedText.text = "Game Speed: " + KeepData.PlayerSpeedMultiplier.ToString();
    }
}
