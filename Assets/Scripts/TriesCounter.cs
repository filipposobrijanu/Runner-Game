using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriesCounter : MonoBehaviour
{

    public GameObject guidetext;
    public float triescount;

    void Start()
    {

        triescount = PlayerPrefs.GetFloat("triescount", triescount) + 1;

        PlayerPrefs.SetFloat("triescount", triescount);

        if (triescount >= 5)
        {

            guidetext.gameObject.SetActive(false);

        }

    }

}
