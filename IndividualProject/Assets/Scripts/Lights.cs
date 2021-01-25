using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public Animator anima;
    public GameController controller;
    private static int score;

    void Start()
    {
        anima.GetComponent<Animator>();
    }

   
    void Update()
    {
        score = GameController.score;

        if (score == 1)
        {
            anima.SetInteger("State", 1);
        }
        if (score == 2)
        {
            anima.SetInteger("State", 2);
        }
        if (score == 3)
        {
            anima.SetInteger("State", 3);
        }
        if (score == 4)
        {
            anima.SetInteger("State", 4);
        }
        if (score == 5)
        {
            anima.SetInteger("State", 5);
        }
        if (score == 6)
        {
            anima.SetInteger("State", 6);
        }


    }

}
