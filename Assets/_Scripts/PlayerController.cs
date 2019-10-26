using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{

    public float speed = 400.0f;
    public Text scoreText;
    public static int count = 0;
    public Text winText;
    public static int RoundCounter= 0 ;


    private void Awake()
    {
        count = 0;
        RoundCounter = 0;
    }
    void FixedUpdate()
    {
        float moveHorazontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorazontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime * KeepData.PlayerSpeedMultiplier);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            scoreText.text = "Current Round Score: " + count;
            
            
            KeepData.HighScore += 1;
           
            KeepData.Currentscore = count;
            if(count >= 19)
            {
                RoundCounter += 1;
                if (RoundCounter >= KeepData.RoundsToPlay)
                {
                    SceneManager.LoadScene("Exit");
                }
                else
                {
                    SceneManager.LoadScene("Game");
                }
            }
            
        }
        
    }

}
