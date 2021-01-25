using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public Animator anim;
    public GameController controller;
    public static int score;

    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        score = GameController.score;

        if (score == 6)
        {
            anim.SetInteger("State", 1);
        }
    }
}
