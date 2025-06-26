using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    [SerializeField] private AudioSource scoresfx;
    private float soundScore;
    private Animator anim;
    private float score;

    void Start()
    {

        anim = GetComponent<Animator>();

    }


    void Update()
    {

        soundScore += Time.deltaTime * 10;

        if (soundScore >= 100)
        {
            anim.SetTrigger("FlickerScore");
            scoresfx.Play();
            soundScore = 0;


        }

        //score += Time.deltaTime * 10;

        //if (score >= 1000)
        //{

        //anim.SetTrigger("RainbowScore");


        //}


    }
}
