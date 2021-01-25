using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutWireBlue : MonoBehaviour
{
    public AudioSource musicSource;
    public GameController controller;
    public Transform BlueSparks;
    public GameObject sparks;
    Animator anim;

    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        anim.SetInteger("State", 1);
        musicSource.Play();
        controller.Score();
        Instantiate(sparks, BlueSparks.position, BlueSparks.rotation);
        


    }
   
}
