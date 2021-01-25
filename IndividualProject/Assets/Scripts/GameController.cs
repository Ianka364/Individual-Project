using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioClip background;
    public AudioClip winMusic;
    public AudioClip lossMusic;
    public Timer timing;
    public Text text;
    public Text loseText;
    public Text scoreText;
    public float timeLeft = 10f;
    public int batteryLevel;
    private bool loss;
    private bool start;
    public static int score;
    private static float time;

    void Start()
    {
        batteryLevel = 6;
        loss = false;
        score = 0;
    }

    void Update()
    {

        time = Timer.timeLeft;

        if (time <= 10)
        {
            if (start == false)
            {
                start = true;

                musicSource.clip = background;
                musicSource.Play();
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        if (time <= 0)
        {
            if (loss == false)
            {
                loss = true;

                musicSource.Stop();
                musicSource.clip = lossMusic;
                musicSource.Play();
            }
            
        }
        
    }


    public void Score()
    { 
            score = score + 1;

        
        if (score == 6)
        {

            musicSource.Stop();
            musicSource.clip = winMusic;
            musicSource.Play();
           
        }   
          
    }

}
