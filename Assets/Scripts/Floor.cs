using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    private Animator anim;
    private float score;

    void Start()
    {

        anim = GetComponent<Animator>();

    }


    void Update()
    {

        //score += Time.deltaTime * 10;

        // (score >= 1000)
        //

        //anim.SetTrigger("RainbowFloor");

        //


    }
}

