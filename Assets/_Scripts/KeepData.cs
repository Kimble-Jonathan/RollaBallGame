using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{
    public static string PlayerName = "default name";
    public static bool OversizedBall;
    public static int RoundsToPlay;
    public static float PlayerSpeedMultiplier = 2.0f;
    public static int Currentscore = 0;
    public static int HighScore ;

    public InputField playerName;
    public Toggle ballSize;
    public Dropdown roundsToPlay;
    public Slider playerSpeedMultiplier;
    
    // Start is called before the first frame update

    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

   
    // Update is called once per frame
    public void UpdateName()
    {
        PlayerName = playerName.text;
    }
    public void BigBall(bool newValue)
    {
        OversizedBall = newValue;
    }
    public void SetRoundsToPlay()
    {
        switch (roundsToPlay.value)
        {
            case 1:
                RoundsToPlay = 1;
                break;
            case 2:
                RoundsToPlay = 2;
                break;
            case 3:
                RoundsToPlay = 3;
                break;
            case 4:
                RoundsToPlay = 4;
                break;
            default:
                RoundsToPlay = 1;
                break;

        }
    }
    public void SetPlayerSpeedMultiplier()
    {
        PlayerSpeedMultiplier = playerSpeedMultiplier.value;
    }
}
