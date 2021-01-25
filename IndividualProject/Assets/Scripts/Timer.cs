using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    Text text;
    public static float timeLeft = 13f;
    public static float timer;
    public static int batteryLevel;
    public Text loseText;
    public GameController controller;


    void Start()
    {
        text = GetComponent<Text>();
        timer = timeLeft;
    }

    void Update()
    {
        Clock();
        batteryLevel = GameController.score;
    }

    public void Clock()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
        }
        if (timeLeft > 0)
        {
            text.text = "" + Mathf.Round(timeLeft);
        }
        if(timeLeft > 10)
        {
            text.text = "";
        }
        if (batteryLevel == 6)
        {
            text.text = "You Win!";
            timeLeft = 50;
        }
        if(timeLeft == 0)
        {
            text.text = "You lose!";
            
        }
    }

}
